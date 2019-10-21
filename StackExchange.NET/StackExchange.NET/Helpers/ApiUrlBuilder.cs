#region Using Directives

using System.Collections.Generic;
using System.Web;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

#endregion

namespace StackExchange.NET.Helpers
{
	public class ApiUrlBuilder : IApiUrlHelper
	{
		private static readonly string BaseUrl = $"https://api.stackexchange.com/2.2/";
		private static string _apiUrl;
		private string _filter;
		private readonly string _apiKey;

		/// <summary>
		/// Constructor used to Build the api url internally
		/// </summary>
		/// <param name="apiKey"></param>
		public ApiUrlBuilder(string apiKey)
		{
			_apiKey = apiKey;
		}
		public static IApiUrlHelper Initialize(string apikey) => new ApiUrlBuilder(apikey);

		public ApiUrlBuilder ForClient(ClientType type, string route = "")
		{
			//Some API url's have hyphens in it. Since its not possible to use Hyphens in enums, using Underscore and replacing it as a workaround!
			if (type.ToString().Contains("_"))
			{
				_apiUrl = $"{BaseUrl}{type.ToString().Replace("_", "-").ToLower()}/";
			}
			if (!(string.IsNullOrEmpty(route) || string.IsNullOrWhiteSpace(route)))
			{
				_apiUrl = $"{BaseUrl}{type.ToString().ToLower()}/{route}";
			}
			else
			{
				_apiUrl = $"{BaseUrl}{type.ToString().ToLower()}/";
			}
			return this;
		}

		public ApiUrlBuilder WithFilter(Filter filter, string inName = "")
		{
			MakeSure.ArgumentNotNull(filter, nameof(filter));

			if (string.IsNullOrEmpty(inName) || string.IsNullOrWhiteSpace(inName))
			{
				_filter = filter.GetQueryParams();
			}
			else
			{
				_filter = $"{filter.GetQueryParams()}&inname={inName}";
			}

			return this;
		}

		public ApiUrlBuilder WithIds(List<string> ids, string route = "")
		{
			MakeSure.ArgumentNotNullOrEmptyEnumerable(ids, nameof(ids));
			var idsToEncode = string.Join(";", ids.ToArray());
			if (string.IsNullOrEmpty(route) || string.IsNullOrWhiteSpace(route))
			{
				_apiUrl = _apiUrl + $"{HttpUtility.UrlEncode(idsToEncode)}";
			}
			else
			{
				_apiUrl = _apiUrl + $"{HttpUtility.UrlEncode(idsToEncode)}/{route}";
			}
			return this;
		}

		public ApiUrlBuilder WithTagAndPeriod(string tag, string period)
		{
			MakeSure.ArgumentNotNull(tag,nameof(tag));
			MakeSure.ArgumentNotNull(period,nameof(period));

			_apiUrl = _apiUrl + $"{tag}/{period}";
			return this;
		}

		public string GetApiUrl()
		{
			_apiUrl = $"{_apiUrl}?key={_apiKey}&{_filter}";

			//Some methods do not have a filter which contains the site attribute,Adding this additional 
			//check here to find and add the site filter if it does not exist in the URL
			if (!_apiUrl.Contains("site"))
			{
				_apiUrl = $"{_apiUrl}&{"&site=stackoverflow&filter=default"}";
			}

			return _apiUrl;
		}
	}

}

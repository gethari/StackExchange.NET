using System.Collections.Generic;
using System.Web;
using StackExchange.NET.Models;

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

		public ApiUrlBuilder ForClient(ClientType type,string route ="")
		{
			if (string.IsNullOrEmpty(route) || string.IsNullOrWhiteSpace(route))
			{
				_apiUrl = $"{BaseUrl}{type.ToString().ToLower()}/";
			}
			else
			{
				_apiUrl = $"{BaseUrl}{type.ToString().ToLower()}/{route}";
			}
			
			return this;
		}

		public ApiUrlBuilder WithFilter(Filter filter, string inName="")
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

		public ApiUrlBuilder WithIds(List<string> ids,string route ="")
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

		public string GetApiUrl()
		{
			_apiUrl = $"{_apiUrl}?key={_apiKey}&{_filter}";
			return _apiUrl;
		}
	}

}

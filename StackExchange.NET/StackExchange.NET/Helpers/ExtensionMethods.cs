#region Using Directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;
using StackExchange.NET.Models;

#endregion

namespace StackExchange.NET.Helpers
{
	internal static class ExtensionMethods
	{
		internal static string GetQueryString(this object obj)
		{
			var properties = from p in obj.GetType().GetProperties()
											 where p.GetValue(obj, null) != null
											 select p.Name.ToLower() + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());

			return string.Join("&", properties.ToArray());
		}

		private static string ToQueryString(this IDictionary<string, object> parameters) =>
			string.Join("&", parameters.Select(x => $"{x.Key.ToLower()}={ x.Value}"));

		internal static string GetQueryParams(this Filter filters)
		{
			if (filters == null)
				return string.Empty;
			//var dictionary = new Dictionary<string, dynamic>()
			//{
			//	{"fromdate",filters.FromDate.ToUnixTime() },
			//	{"todate",filters.ToDate.ToUnixTime() },
			//	{"max",filters.Max.ToUnixTime() },
			//	{"min", filters.Min.ToUnixTime()},
			//	{"order", filters.Order.ToString().ToLower()},
			//	{"Page", filters.Page},
			//	{"PageSize", filters.PageSize},
			//	{"Sort", filters.Sort.ToString().ToLower()},
			//	{"Site", filters.Site.ToLower()},
			//};

			var dictionary = filters.AddValidKeys();
			return dictionary.ToQueryString();
		}

		internal static Dictionary<string, dynamic> AddValidKeys(this Filter filter)
		{
			var result = new Dictionary<string, dynamic>();

			#region IsThereABetterWayofDoingThis

			if (filter.FromDate != null)
				result.Add("fromdata", filter.FromDate.ToUnixTime());
			if (filter.ToDate != null)
				result.Add("todate", filter.ToDate.ToUnixTime());
			if (filter.Max != null)
				result.Add("max", filter.Max.ToUnixTime());
			if (filter.Min != null)
				result.Add("min", filter.Min.ToUnixTime());
			if (filter.Order != null)
				result.Add("order", filter.Order.ToString().ToLower());
			if (filter.Page != null)
				result.Add("page", filter.Page);
			if (filter.PageSize != null)
				result.Add("pageSize", filter.PageSize);
			if (filter.Sort != null)
				result.Add("sort", filter.Sort.ToString().ToLower());
			if (filter.Site != null)
				result.Add("site", filter.Site.ToLower());

			#endregion

			return result;
		}

		internal static BaseResponse<T> ValidateApiResponse<T>(this Data<T> data)
		{
			var result = new BaseResponse<T>();
			try
			{
				if (data.ErrorId.HasValue)
					throw new Exceptions.StackExchangeApiException(data.ErrorId.Value, data.ErrorName, data.ErrorMessage);

				result.Data = data;
				result.Success = true;
			}
			catch (Exception ex)
			{
				result.Exception = ex;
				result.Success = false;
			}
			return result;
		}

		internal static dynamic ToUnixTime(this DateTime? dateTime)
		{
			if (dateTime.HasValue)
				return ((DateTimeOffset)dateTime).ToUnixTimeSeconds();
			return null;
		}

		internal static T ReadAsJsonAsync<T>(this HttpResponseMessage content)
		{
			return JsonConvert.DeserializeObject<T>(content.Content.ReadAsStringAsync().Result);
		}
	}
}
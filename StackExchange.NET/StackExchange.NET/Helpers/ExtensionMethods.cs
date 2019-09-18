using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;
using StackExchange.NET.Models;

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
			var dictionary = new Dictionary<string, dynamic>()
			{
				{"fromdate",filters.FromDate.ToUnixTime() },
				{"todate",filters.ToDate.ToUnixTime() },
				{"max",filters.Max.ToUnixTime() },
				{"min", filters.Min.ToUnixTime()},
				{"order", filters.Order.ToString().ToLower()},
				{"Page", filters.Page},
				{"PageSize", filters.PageSize},
				{"Sort", filters.Sort.ToString().ToLower()},
				{"Site", filters.Site.ToLower()},
			};

			return dictionary.ToQueryString();
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
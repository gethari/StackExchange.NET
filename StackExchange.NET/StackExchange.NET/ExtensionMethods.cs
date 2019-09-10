using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StackExchange.NET.Models;

namespace StackExchange.NET
{
	internal static class ExtensionMethods
	{
		public static string GetQueryString(this object obj)
		{
			var properties = from p in obj.GetType().GetProperties()
											 where p.GetValue(obj, null) != null
											 select p.Name.ToLower() + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());

			return string.Join("&", properties.ToArray());
		}

		private static string ToQueryString(this IDictionary<string, object> parameters) =>
			string.Join("&", parameters.Select(x => $"{x.Key.ToLower()}={ x.Value}"));

		internal static string GetQueryParams(this QueryFilters filters)
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

		//internal static string GetEncodedUrl(this string url)
		//{

		//}
	}

	internal static class DateTimeExtensions
	{
		public static dynamic ToUnixTime(this DateTime? dateTime)
		{
			if (dateTime.HasValue)
				return ((DateTimeOffset)dateTime).ToUnixTimeSeconds();
			return null;
		}
	}
}
#region Using Directives

using System.Collections.Generic;
using System.Web;
using Newtonsoft.Json;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

#endregion

namespace StackExchange.NET.Clients
{
	public partial class StackExchangeClient : IBadges
	{
		public IBadges Badges => this;

		Badges IBadges.GetAllBadges(BadgeFilters filters, string inName)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/badges?key={_apiKey}&{apiParams}&inname={inName}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var badges = JsonConvert.DeserializeObject<Badges>(response);
			return badges;
		}

		Badges IBadges.GetBadgesByIds(List<string> ids, BadgeFilters filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/badges/";
			var idsToEncode = string.Join(";", ids.ToArray());
			url = url + $"{HttpUtility.UrlEncode(idsToEncode)}" + $"?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var badges = JsonConvert.DeserializeObject<Badges>(response);
			return badges;
		}

		Badges IBadges.GetNonTaggedBadges(List<string> ids, BadgeFilters filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/badges/name";
			var idsToEncode = string.Join(";", ids.ToArray());
			url = url + $"{HttpUtility.UrlEncode(idsToEncode)}" + $"?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var badges = JsonConvert.DeserializeObject<Badges>(response);
			return badges;
		}

		Badges IBadges.GetRecentlyAwardedBadges(BadgeFilters filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/badges/recipients"+ $"?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var badges = JsonConvert.DeserializeObject<Badges>(response);
			return badges;
		}

		Badges IBadges.GetRecentlyAwardedBadgesByIds(List<string> ids, BadgeFilters filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/badges/";
			var idsToEncode = string.Join(";", ids.ToArray());
			url = url + $"{HttpUtility.UrlEncode(idsToEncode)}/recipients" + $"?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var badges = JsonConvert.DeserializeObject<Badges>(response);
			return badges;
		}

		Badges IBadges.GetAllTaggedBadges(BadgeFilters filters, string inName)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/badges/tags"+ $"?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var badges = JsonConvert.DeserializeObject<Badges>(response);
			return badges;
		}
	}
}

#region Using Directives

using System.Collections.Generic;
using StackExchange.NET.Helpers;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

#endregion

namespace StackExchange.NET.Clients
{
	public partial class StackExchangeClient : IBadges
	{
		public IBadges Badges => this;

		BaseResponse<Badge> IBadges.GetAllBadges(BadgeFilters filters, string inName)
		{
			MakeSure.ArgumentNotNullOrEmptyString(inName, nameof(inName));
			var url = ApiUrlBuilder
				.Initialize(_apiKey)
				.ForClient(ClientType.Badges)
				.WithFilter(filters, inName)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Badge>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Badge> IBadges.GetBadgesByIds(List<string> ids, BadgeFilters filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Badges)
				.WithFilter(filters)
				.WithIds(ids)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Badge>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Badge> IBadges.GetNonTaggedBadges(List<string> ids, BadgeFilters filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Badges, "name")
				.WithFilter(filters)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Badge>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Badge> IBadges.GetRecentlyAwardedBadges(BadgeFilters filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Badges, "recipients")
				.WithFilter(filters)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Badge>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Badge> IBadges.GetRecentlyAwardedBadgesByIds(List<string> ids, BadgeFilters filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Badges)
				.WithFilter(filters)
				.WithIds(ids, "recipients")
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Badge>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Badge> IBadges.GetAllTaggedBadges(BadgeFilters filters, string inName)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Badges, "tags")
				.WithFilter(filters, inName)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Badge>>().ValidateApiResponse();
			return response;
		}
	}
}

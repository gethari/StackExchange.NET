using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StackExchange.NET.Models
{
	public class Badges
	{
		[JsonProperty("items")]
		public List<Badge> Items { get; set; }

		[JsonProperty("has_more")]
		public bool HasMore { get; set; }

		[JsonProperty("quota_max")]
		public long QuotaMax { get; set; }

		[JsonProperty("quota_remaining")]
		public long QuotaRemaining { get; set; }
	}

	public class Badge
	{
		[JsonProperty("badge_type")]
		public string BadgeType { get; set; }

		[JsonProperty("award_count")]
		public long AwardCount { get; set; }

		[JsonProperty("rank")]
		public string Rank { get; set; }

		[JsonProperty("badge_id")]
		public long BadgeId { get; set; }

		[JsonProperty("link")]
		public Uri Link { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public enum BadgeSort
	{
		Rank,
		Name,
		Type
	}
	public class BadgeFilters : Filter
	{
		public BadgeFilters()
		{
			Order = Models.Order.Desc;
			Sort = BadgeSort.Name;
			Site = "stackoverflow";
		}
	}

}

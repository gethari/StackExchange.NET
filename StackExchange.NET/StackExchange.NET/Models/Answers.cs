using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StackExchange.NET.Models
{
	public class Answers
	{
		[JsonProperty("items")]
		public List<Item> Items { get; set; }

		[JsonProperty("has_more")]
		public bool HasMore { get; set; }

		[JsonProperty("quota_max")]
		public long QuotaMax { get; set; }

		[JsonProperty("quota_remaining")]
		public long QuotaRemaining { get; set; }
	}
	public class Item
	{
		[JsonProperty("owner")]
		public Owner Owner { get; set; }

		[JsonProperty("is_accepted")]
		public bool IsAccepted { get; set; }

		[JsonProperty("score")]
		public long Score { get; set; }

		[JsonProperty("last_activity_date")]
		public long LastActivityDate { get; set; }

		[JsonProperty("last_edit_date", NullValueHandling = NullValueHandling.Ignore)]
		public long? LastEditDate { get; set; }

		[JsonProperty("creation_date")]
		public long CreationDate { get; set; }

		[JsonProperty("answer_id")]
		public long AnswerId { get; set; }

		[JsonProperty("question_id")]
		public long QuestionId { get; set; }
	}
	public class Owner
	{
		[JsonProperty("reputation")]
		public long Reputation { get; set; }

		[JsonProperty("user_id")]
		public long UserId { get; set; }

		[JsonProperty("user_type")]
		public string UserType { get; set; }

		[JsonProperty("accept_rate", NullValueHandling = NullValueHandling.Ignore)]
		public long? AcceptRate { get; set; }

		[JsonProperty("profile_image")]
		public Uri ProfileImage { get; set; }

		[JsonProperty("display_name")]
		public string DisplayName { get; set; }

		[JsonProperty("link")]
		public Uri Link { get; set; }

	}
}


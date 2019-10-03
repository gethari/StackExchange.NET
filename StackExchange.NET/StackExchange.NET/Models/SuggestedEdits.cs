using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StackExchange.NET.Models
{
	public class SuggestedEdits
	{
		[JsonProperty("proposing_user")]
		public ProposingUser ProposingUser { get; set; }

		[JsonProperty("creation_date")]
		public long CreationDate { get; set; }

		[JsonProperty("post_type")]
		public PostType PostType { get; set; }

		[JsonProperty("post_id")]
		public long PostId { get; set; }

		[JsonProperty("suggested_edit_id")]
		public long SuggestedEditId { get; set; }

		[JsonProperty("comment")]
		public string Comment { get; set; }

		[JsonProperty("rejection_date", NullValueHandling = NullValueHandling.Ignore)]
		public long? RejectionDate { get; set; }

		[JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
		public List<string> Tags { get; set; }

		[JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
		public string Title { get; set; }

		[JsonProperty("approval_date", NullValueHandling = NullValueHandling.Ignore)]
		public long? ApprovalDate { get; set; }
	}

	public class ProposingUser
	{
		[JsonProperty("reputation")]
		public long Reputation { get; set; }

		[JsonProperty("user_id")]
		public long UserId { get; set; }

		[JsonProperty("user_type")]
		public UserType UserType { get; set; }

		[JsonProperty("profile_image")]
		public Uri ProfileImage { get; set; }

		[JsonProperty("display_name")]
		public string DisplayName { get; set; }

		[JsonProperty("link")]
		public Uri Link { get; set; }

		[JsonProperty("accept_rate", NullValueHandling = NullValueHandling.Ignore)]
		public long? AcceptRate { get; set; }
	}

	public enum PostType
	{
		Answer, Question
	}

	public enum UserType
	{
		Registered
	}

}

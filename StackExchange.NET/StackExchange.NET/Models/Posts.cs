using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StackExchange.NET.Models
{
	public class Post
	{
		[JsonProperty("owner")]
		public Owner Owner { get; set; }

		[JsonProperty("score")]
		public long Score { get; set; }

		[JsonProperty("last_edit_date")]
		public long LastEditDate { get; set; }

		[JsonProperty("last_activity_date")]
		public long LastActivityDate { get; set; }

		[JsonProperty("creation_date")]
		public long CreationDate { get; set; }

		[JsonProperty("post_type")]
		public string PostType { get; set; }

		[JsonProperty("post_id")]
		public long PostId { get; set; }

		[JsonProperty("link")]
		public Uri Link { get; set; }
	}

	public enum PostSort
	{
		Votes,
		Creation
	}
	public class PostFilter : Filter
	{
		public PostFilter()
		{
			Order = Models.Order.Desc;
			Sort = PostSort.Creation;
			Site = "stackoverflow";
		}
	}

	public enum SuggestedEdit
	{
		Creation,
		Approval,
		Rejection
	}
	public class SuggestedEditFilter : Filter
	{
		public SuggestedEditFilter()
		{
			Order = Models.Order.Desc;
			Sort = SuggestedEdit.Creation;
			Site = "stackoverflow";
		}
	}
}

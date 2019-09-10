using System.Collections.Generic;
using Newtonsoft.Json;

namespace StackExchange.NET.Models
{
	public class Comments
	{
		[JsonProperty("items")]
		public List<Comment> Items { get; set; }

		[JsonProperty("has_more")]
		public bool HasMore { get; set; }

		[JsonProperty("quota_max")]
		public long QuotaMax { get; set; }

		[JsonProperty("quota_remaining")]
		public long QuotaRemaining { get; set; }
	}

	public class Comment
	{
		[JsonProperty("owner")]
		public Owner Owner { get; set; }

		[JsonProperty("reply_to_user")]
		public Owner ReplyToUser { get; set; }

		[JsonProperty("edited")]
		public bool Edited { get; set; }

		[JsonProperty("score")]
		public long Score { get; set; }

		[JsonProperty("creation_date")]
		public long CreationDate { get; set; }

		[JsonProperty("post_id")]
		public long PostId { get; set; }

		[JsonProperty("comment_id")]
		public long CommentId { get; set; }
	}

	public enum CommentSort
	{
		Creation,
		Votes
	}

	public class CommentFilter : Filter
	{
		public CommentFilter()
		{
			Order = Models.Order.Desc;
			Sort = CommentSort.Creation;
			Site = "stackoverflow";
		}
	}
}

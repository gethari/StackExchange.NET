using System;
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
}

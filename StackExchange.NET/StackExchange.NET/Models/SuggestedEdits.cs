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
		public Enums.PostType PostType { get; set; }

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
}

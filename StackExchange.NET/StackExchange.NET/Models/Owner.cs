using System;
using Newtonsoft.Json;

namespace StackExchange.NET.Models
{
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
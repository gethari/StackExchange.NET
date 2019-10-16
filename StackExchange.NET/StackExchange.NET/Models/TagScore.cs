using Newtonsoft.Json;

namespace StackExchange.NET.Models
{
    public class TagScore
    {
	    [JsonProperty("user")]
	    public Owner User { get; set; }

	    [JsonProperty("post_count")]
	    public long PostCount { get; set; }

	    [JsonProperty("score")]
	    public long Score { get; set; }
    }
}

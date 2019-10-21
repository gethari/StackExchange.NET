using Newtonsoft.Json;

namespace StackExchange.NET.Models
{
    public class TagSynonym
    {
	    [JsonProperty("creation_date")]
	    public long CreationDate { get; set; }

	    [JsonProperty("applied_count")]
	    public long AppliedCount { get; set; }

	    [JsonProperty("to_tag")]
	    public string ToTag { get; set; }

	    [JsonProperty("from_tag")]
	    public string FromTag { get; set; }

	    [JsonProperty("last_applied_date", NullValueHandling = NullValueHandling.Ignore)]
	    public long? LastAppliedDate { get; set; }
    }
}

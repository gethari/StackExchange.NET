using Newtonsoft.Json;

namespace StackExchange.NET.Models
{
    public class TagWiki
    {
	    [JsonProperty("excerpt_last_edit_date")]
	    public long ExcerptLastEditDate { get; set; }

	    [JsonProperty("body_last_edit_date")]
	    public long BodyLastEditDate { get; set; }

	    [JsonProperty("excerpt")]
	    public string Excerpt { get; set; }

	    [JsonProperty("tag_name")]
	    public string TagName { get; set; }
    }
}

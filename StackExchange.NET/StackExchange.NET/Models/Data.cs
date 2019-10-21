using Newtonsoft.Json;

namespace StackExchange.NET.Models
{
    public class Data<T>
    {
        [JsonProperty("error_id")]
        public long? ErrorId { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        [JsonProperty("error_name")]
        public string ErrorName { get; set; }
        [JsonProperty("items")]
        public T[] Items { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("quota_max")]
        public long QuotaMax { get; set; }

        [JsonProperty("quota_remaining")]
        public long QuotaRemaining { get; set; }
    }
}
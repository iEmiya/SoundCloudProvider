using Newtonsoft.Json;

namespace SoundCloudProvider.Json
{
    [JsonObject]
    public class UserItemData
    {
        [JsonProperty("id")]
        public long Id { get; internal set; }

        [JsonProperty("permalink")]
        public string Permalink { get; internal set; }

        [JsonProperty("username")]
        public string Username { get; internal set; }

        [JsonProperty("uri")]
        public string Uri { get; internal set; }

        [JsonProperty("permalink_url")]
        public string PermalinkUrl { get; internal set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; internal set; }
    }
}

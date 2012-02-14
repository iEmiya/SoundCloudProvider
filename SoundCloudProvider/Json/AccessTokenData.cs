using Newtonsoft.Json;

namespace SoundCloudProvider.Json
{
    [JsonObject]
    internal class AccessTokenData
    {
        [JsonProperty("access_token")]
        public string Token { get; internal set; }

        [JsonProperty("scope")]
        public string Scope { get; internal set; }
    }
}

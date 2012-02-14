using Newtonsoft.Json;

namespace SoundCloudProvider.Json
{
    [JsonObject]
    public class UserData : UserItemData
    {
        [JsonProperty("country")]
        public string Country { get; internal set; }

        [JsonProperty("full_name")]
        public string FullName { get; internal set; }

        [JsonProperty("city")]
        public string City { get; internal set; }

        [JsonProperty("description")]
        public string Description { get; internal set; }

        [JsonProperty("discogs_name")]
        public string DiscogsName { get; internal set; }

        [JsonProperty("myspace_name")]
        public string MyspaceName { get; internal set; }

        [JsonProperty("website")]
        public string Website { get; internal set; }

        [JsonProperty("website_title")]
        public string WebsiteTitle { get; internal set; }

        [JsonProperty("online")]
        public bool Online { get; internal set; }

        [JsonProperty("track_count")]
        public long TrackCount { get; internal set; }

        [JsonProperty("playlist_count")]
        public long PlaylistCount { get; internal set; }

        [JsonProperty("public_favorites_count")]
        public long PublicFavoritesCount { get; internal set; }

        [JsonProperty("followers_count")]
        public long FollowersCount { get; internal set; }

        [JsonProperty("followings_count")]
        public long FollowingsCount { get; internal set; }
    }
}

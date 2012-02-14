using Newtonsoft.Json;

namespace SoundCloudProvider.Json
{
    [JsonObject]
    public class MeData : UserItemData
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
        public string MySpaceName { get; internal set; }

        [JsonProperty("website")]
        public string Website { get; internal set; }

        [JsonProperty("website_title")]
        public string WebsiteTitle { get; internal set; }

        [JsonProperty("online")]
        public bool online { get; internal set; }

        [JsonProperty("track_count")]
        public long TrackCount { get; internal set; }

        [JsonProperty("playlist_count")]
        public long PlaylistCount { get; internal set; }

        [JsonProperty("public_favorites_count")]
        public long PublicFavoritesCount { get; internal set; }

        [JsonProperty("followers_count")]
        public long FollowersCount { get; internal set; }

        [JsonProperty("plan")]
        public string Plan { get; internal set; }

        [JsonProperty("private_tracks_count")]
        public long PrivateTracksCount { get; internal set; }

        [JsonProperty("private_playlists_count")]
        public long PrivatePlaylistsCount { get; internal set; }

        [JsonProperty("primary_email_confirmed")]
        public bool PrimaryEmailConfirmed { get; internal set; }
    }
}

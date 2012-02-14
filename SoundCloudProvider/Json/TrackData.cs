using System;
using Newtonsoft.Json;

namespace SoundCloudProvider.Json
{
    [JsonObject]
    public class TrackData
    {
        [JsonProperty("id")]
        public long Id { get; internal set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; internal set; }

        [JsonProperty("user_id")]
        public long UserId { get; internal set; }

        [JsonProperty("duration")]
        public long Duration { get; internal set; }

        [JsonProperty("commentable")]
        public bool Commentable { get; internal set; }

        [JsonProperty("state")]
        public string State { get; internal set; }

        [JsonProperty("sharing")]
        public string Sharing { get; internal set; }

        [JsonProperty("tag_list")]
        public string TagList { get; internal set; }

        [JsonProperty("permalink")]
        public string Permalink { get; internal set; }

        [JsonProperty("description")]
        public string Description { get; internal set; }

        [JsonProperty("streamable")]
        public bool Streamable { get; internal set; }

        [JsonProperty("downloadable")]
        public bool Downloadable { get; internal set; }

        [JsonProperty("genre")]
        public string Genre { get; internal set; }

        [JsonProperty("release")]
        public string Release { get; internal set; }

        [JsonProperty("purchase_url")]
        public string PurchaseUrl { get; internal set; }

        [JsonProperty("label_id")]
        public string LabelId { get; internal set; }

        [JsonProperty("label_name")]
        public string LabelName { get; internal set; }

        [JsonProperty("isrc")]
        public string ISRC { get; internal set; }

        [JsonProperty("video_url")]
        public string VideoUrl { get; internal set; }

        [JsonProperty("track_type")]
        public string TrackType { get; internal set; }

        [JsonProperty("key_signature")]
        public string KeySignature { get; internal set; }

        [JsonProperty("bpm")]
        public long? BPM { get; internal set; }

        [JsonProperty("title")]
        public string Title { get; internal set; }

        [JsonProperty("release_year")]
        public string ReleaseYear { get; internal set; }

        [JsonProperty("release_month")]
        public string ReleaseMonth { get; internal set; }

        [JsonProperty("Release_day")]
        public string ReleaseDay { get; internal set; }

        [JsonProperty("original_format")]
        public string OriginalFormat { get; internal set; }

        [JsonProperty("license")]
        public string License { get; internal set; }

        [JsonProperty("uri")]
        public string Uri { get; internal set; }

        [JsonProperty("permalink_url")]
        public string PermalinkUrl { get; internal set; }

        [JsonProperty("artwork_url")]
        public string ArtworkUrl { get; internal set; }

        [JsonProperty("waveform_url")]
        public string WaveformUrl { get; internal set; }

        [JsonProperty("user")]
        public UserItemData User { get; internal set; }

        [JsonProperty("stream_url")]
        public string StreamUrl { get; internal set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; internal set; }

        [JsonProperty("playback_count")]
        public long PlaybackCount { get; internal set; }

        [JsonProperty("download_count")]
        public long DownloadCount { get; internal set; }

        [JsonProperty("favoritings_count")]
        public long FavoritingsCount { get; internal set; }

        [JsonProperty("comment_count")]
        public long CommentCount { get; internal set; }

        [JsonProperty("attachments_uri")]
        public string AttachmentsUri { get; internal set; }
    }
}

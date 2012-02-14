using SoundCloudProvider.Json;
using SoundCloudProvider.Net;

namespace SoundCloudProvider.API.Console
{
    public class TracksClientImp
    {
        private const string Path = "https://api.soundcloud.com/tracks";

        private readonly string _oauth;

        public TracksClientImp(string token)
        {
            _oauth = "oauth_token=" + token;
        }

        public TrackData GetTrack(long track_id)
        {
            const string pattern = Path + "/{0}.json";
            string requestUriString = string.Format(pattern, track_id);
            IRequestInfo requestInfo = new RequestInfoImp()
            {
                UriString = RequestUtility.GetOAuthRequestUriString(_oauth, requestUriString),
            };

            string json = RequestUtility.GetResponseString(requestInfo);
            var result = JsonHelper.Deserialize<TrackData>(json);
            return result;
        }
    }
}

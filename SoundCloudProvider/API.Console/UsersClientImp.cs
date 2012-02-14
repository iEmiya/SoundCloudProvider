using SoundCloudProvider.Json;
using SoundCloudProvider.Net;

namespace SoundCloudProvider.API.Console
{
    public class UsersClientImp
    {
        private const string Path = "https://api.soundcloud.com/users";

        private readonly string _oauth;

        public UsersClientImp(string token)
        {
            _oauth = "oauth_token=" + token;
        }

        public UserData GetUser(long user_id)
        {
            const string pattern = Path + "/{0}.json";
            string requestUriString = string.Format(pattern, user_id);
            IRequestInfo requestInfo = new RequestInfoImp()
            {
                UriString = RequestUtility.GetOAuthRequestUriString(_oauth, requestUriString),
            };

            string json = RequestUtility.GetResponseString(requestInfo);
            var result = JsonHelper.Deserialize<UserData>(json);
            return result;
        }

        public TrackData[] GetTracks(long user_id)
        {
            const string pattern = Path + "/{0}/tracks.json";
            string requestUriString = string.Format(pattern, user_id);
            IRequestInfo requestInfo = new RequestInfoImp()
            {
                UriString = RequestUtility.GetOAuthRequestUriString(_oauth, requestUriString),
            };

            string json = RequestUtility.GetResponseString(requestInfo);
            var result = JsonHelper.Deserialize<TrackData[]>(json);
            return result;
        }
    }
}

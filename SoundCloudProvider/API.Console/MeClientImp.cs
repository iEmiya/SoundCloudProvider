using SoundCloudProvider.Json;
using SoundCloudProvider.Net;

namespace SoundCloudProvider.API.Console
{
    public class MeClientImp
    {
        private const string Path = "https://api.soundcloud.com/me";

        private readonly string _oauth;

        public MeClientImp(string token)
        {
            _oauth = "oauth_token=" + token;
        }

        public MeData GetMe()
        {
            const string pattern = Path + ".json";
            string requestUriString = pattern;
            IRequestInfo requestInfo = new RequestInfoImp()
            {
                UriString = RequestUtility.GetOAuthRequestUriString(_oauth, requestUriString),
            };

            string json = RequestUtility.GetResponseString(requestInfo);
            var result = JsonHelper.Deserialize<MeData>(json);
            return result;
        }
    }
}

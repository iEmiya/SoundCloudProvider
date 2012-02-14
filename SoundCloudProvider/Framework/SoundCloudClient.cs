using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using SoundCloudProvider.Core;
using SoundCloudProvider.Json;

namespace SoundCloudProvider.Framework
{
    public class SoundCloudClient
    {
        private const int ApiVersion = 1;
        
        private const string Authorize = "authorize";
        private const string Token = "access_token";
        private const string Development = "development";
        private const string Production = "production";

        internal static readonly Encoding Encoding = Encoding.UTF8;

        private static readonly Dictionary<string, string> Paths = new Dictionary<string, string>
        {
            {Authorize, "connect"},
            {Token, "oauth2/token"}
        };

        private static readonly Dictionary<string, string> Domains = new Dictionary<string, string>
        {
            {Development, "sandbox-soundcloud.com"},
            {Production, "soundcloud.com"}
        };

        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _redirectUri;
        private readonly bool _development;


        private string _accessToken;


        public SoundCloudClient(string clientId, string clientSecret, string redirectUri = null, bool development = false)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _redirectUri = redirectUri;
            _development = development;
        }

        public string AccessToken
        {
            get { return this._accessToken; }
            set { this._accessToken = value; }
        }

        public string GetAuthorizeUrl(Dictionary<string, string> @params = null)
        {
            if (@params == null)
                @params = new Dictionary<string, string>();

            var defaultParams = new Dictionary<string, string>
                                    {
                                        {"client_id", _clientId},
                                        {"redirect_uri", _redirectUri},
                                        {"response_type", "code"},
                                    };
            @params = Merge(defaultParams, @params);
            return BuildUrl(Paths[Authorize], @params, false);
        }

        public string GetAccessTokenUrl(Dictionary<string, string> @params = null)
        {
            return BuildUrl(Paths[Token], @params, false);
        }

        public string GetAccessToken(string code = "",
            Dictionary<string, string> postData = null)
        {
            if (postData == null)
                postData = new Dictionary<string, string>();

            var defaultPostData = new Dictionary<string, string>
            {
                {"code", code},
                {"client_id", _clientId},
                {"client_secret", _clientSecret},
                {"redirect_uri", _redirectUri},
                {"grant_type", "authorization_code"}
            };

            postData = Merge(defaultPostData, postData);
            return GetAccessTokenInternal(postData);
        }

        private static Dictionary<TKey, TValue> Merge<TKey, TValue>(Dictionary<TKey, TValue> source, Dictionary<TKey, TValue> target)
        {
            var array = new Dictionary<TKey, TValue>();
            foreach (var s in source)
            {
                array.Add(s.Key, s.Value);
            }
            foreach (var t in target)
            {
                array.Add(t.Key, t.Value);
            }
            return array;
        }

        private static string HttpBuildQuery(Dictionary<string, string> @params)
        {
            var list = @params.Select(param => param.Key + "=" + param.Value);
            return string.Join("&", list);
        }

        private static string Request(string path, string method = "GET", Dictionary<string, string> options = null)
        {
            if (options == null)
                options = new Dictionary<string, string>();

            var urlBuilder = new StringBuilder(path);
            if (options.Count > 0)
            {
                urlBuilder.Append(path.IndexOf('?') > -1 ? "" : "?");
                urlBuilder.Append(HttpBuildQuery(options));
            }

            string url = urlBuilder.ToString();
            var webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = method;

            string resultString;
            using (var webResponse = webRequest.GetResponse())
            {
                using (var stream = webResponse.GetResponseStream())
                using (var reader = new StreamReader(stream, Encoding))
                {
                    resultString = reader.ReadToEnd();
                }
            }

            return resultString;
        }

        private string BuildUrl(string path, Dictionary<string, string> @params = null, bool includeVersion = true)
        {
            if (@params == null)
                @params = new Dictionary<string, string>();

            if (string.IsNullOrEmpty(_accessToken))
            {
                @params["consumer_key"] = _clientId;
            }

            StringBuilder urlBuilder;
            if (Regex.IsMatch(path, "^https?://"))
            {
                urlBuilder = new StringBuilder(path);
            }
            else
            {
                urlBuilder = new StringBuilder("https://");
                urlBuilder.Append((!Regex.IsMatch(path, "connect")) ? "api." : "");
                urlBuilder.Append((_development)
                    ? Domains[Development]
                    : Domains[Production]);
                urlBuilder.Append("/");
                urlBuilder.Append((includeVersion) ? "v" + ApiVersion + "/" : "");
                urlBuilder.Append(path);
            }

            urlBuilder.Append((@params.Count > 0) ? "?" + HttpBuildQuery(@params) : "");
            return urlBuilder.ToString();
        }

        private string GetAccessTokenInternal(Dictionary<string, string> postData)
        {
            string url = GetAccessTokenUrl(postData);
            string resultString = Request(url, "POST", postData);
            var response = JsonHelper.Deserialize<AccessTokenData>(resultString);
            _accessToken = response.Token;
            return _accessToken;
        }
    }
}

using System;
using System.Web.UI;
using SoundCloudProvider.Framework;

namespace SoundCloudTests
{
    public partial class callback : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["error"] != null)
            {
                string error = Request["error"];
                string error_description = Request["error_description"];

                if (error == "access_denied")
                {
                    // доступ запрещен
                    Response.Redirect("~/access_denied.aspx", true);
                }

                errorLabel.Text = error;
                error_descriptionLabel.Text = error_description;

                return;
            }

            if (Request["code"] != null)
            {
                object obj = Session[Settings.SoundCloudClientSessionKey];
                if (obj == null)
                {
                    // TODO: 2012-02-14 Emiya: Потерян клиент для работы oAuth2
                    Response.Redirect("~/default.aspx", true);
                }
                var client = obj as SoundCloudClient;
                if (client == null)
                {
                    // TODO: 2012-02-14 Emiya: Ожидалось получить клиент для работы oAuth2
                    Response.Redirect("~/default.aspx", true);
                }

                string code = Request["code"];
                string token = client.GetAccessToken(code);

                tokenLabel.Text = token;

                // храним token для доступа к SoundCloud
                // GET https://api.soundcloud.com/me?oauth_token=@token
            }
        }
    }
}
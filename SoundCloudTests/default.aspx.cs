using System;
using System.Configuration;
using System.Web.UI;
using SoundCloudProvider.Framework;

namespace SoundCloudTests
{
    public partial class _default : Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        protected void tbGo_Click(object sender, EventArgs e)
        {
            // TODO: 2012-02-14 Emiya : Перенести в Page_Load
            object obj = Session[Settings.SoundCloudClientSessionKey];
            if (obj == null)
            {
                string consumer_key = ConfigurationManager.AppSettings["consumerKey"];
                string consumer_secret = ConfigurationManager.AppSettings["consumerSecret"];
                string redirectUri = ConfigurationManager.AppSettings["redirectUri"];
                const bool isDebug = false; // TODO: 2012-02-14 Emiya : после отладки удалить

                var client = new SoundCloudClient(consumer_key, consumer_secret, redirectUri, isDebug);
                string authorizeUrl = client.GetAuthorizeUrl();
                Session[Settings.SoundCloudClientSessionKey] = client;
                Response.Redirect(authorizeUrl, true);
            }
            Session[Settings.SoundCloudClientSessionKey] = obj;
            Response.Redirect("~/callback.aspx", true);
        }

        protected void tbReset_Click(object sender, EventArgs e)
        {
            Session[Settings.SoundCloudClientSessionKey] = null;
        }
    }
}
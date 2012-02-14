using System;
using System.Web.UI;
using SoundCloudProvider.API.Console;

namespace SoundCloudTests
{
    public partial class sandbox : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            const string token = Settings.oAuthTokenDebug;
            var meConsole = new MeClientImp(token);
            var usersConsole = new UsersClientImp(token);
            var tracksConsole = new TracksClientImp(token);

            var me = meConsole.GetMe();

            const long track_id = 17560362;
            var track = tracksConsole.GetTrack(track_id);

            const long userId = 5484312;
            var user = usersConsole.GetUser(userId);
            var tracks = usersConsole.GetTracks(userId);

            UserIdLabel.Text = user.Id.ToString();
            FullNameLabel.Text = user.FullName;

            tracksGridView.DataSource = tracks;
            tracksGridView.DataBind();
        }
    }
}
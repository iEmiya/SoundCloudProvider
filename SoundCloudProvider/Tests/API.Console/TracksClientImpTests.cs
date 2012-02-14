using NUnit.Framework;
using SoundCloudProvider.API.Console;

namespace SoundCloudProvider.Tests.API.Console
{
    [TestFixture]
    public class TracksClientImpTests
    {
        private TracksClientImp _tracksConsole;

        [SetUp]
        public void SetUp()
        {
            _tracksConsole = new TracksClientImp(Settings.oAuthTokenDebug);
        }

        [TearDown]
        public void TearDown()
        {
            _tracksConsole = null;
        }

        [Test]
        [TestCase(17560360)]
        [TestCase(17560362)]
        [TestCase(17560363)]
        [TestCase(29683580)]
        [TestCase(29683581)]
        [TestCase(27045201)]
        [TestCase(22500696)]
        public void GetTrack(long track_id)
        {
            var track = _tracksConsole.GetTrack(track_id);
            Assert.NotNull(track);
            Assert.NotNull(track.User);

            Assert.That(track.Id, Is.EqualTo(track_id));
            Assert.That(track.Sharing, Is.EqualTo("public"));
            Assert.That(track.Downloadable, Is.True);
            Assert.That(track.License, Is.EqualTo("all-rights-reserved"));
            Assert.That(track.Uri, Is.EqualTo("https://api.soundcloud.com/tracks/" + track_id));
            Assert.That(track.StreamUrl, Is.EqualTo("https://api.soundcloud.com/tracks/" + track_id + "/stream"));
            Assert.That(track.DownloadUrl, Is.EqualTo("https://api.soundcloud.com/tracks/" + track_id + "/download"));
            Assert.That(track.AttachmentsUri, Is.EqualTo("https://api.soundcloud.com/tracks/" + track_id + "/attachments"));
        }
    }
}

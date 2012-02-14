using NUnit.Framework;
using SoundCloudProvider.API.Console;

namespace SoundCloudProvider.Tests.API.Console
{
    [TestFixture]
    public class UsersClientImpTests
    {
        private UsersClientImp _usersConsole;

        [SetUp]
        public void SetUp()
        {
            _usersConsole = new UsersClientImp(Settings.oAuthTokenDebug);
        }

        [TearDown]
        public void TearDown()
        {
            _usersConsole = null;
        }

        [Test]
        [TestCase(5484312)]
        [TestCase(11027200)]
        [TestCase(9826132)]
        [TestCase(8813097)]
        [TestCase(8597385)]
        [TestCase(8597385)]
        [TestCase(10775150)]
        [TestCase(10511219)]
        public void GetUser(long user_id)
        {
            var user = _usersConsole.GetUser(user_id);
            Assert.NotNull(user);
            Assert.That(user.Id, Is.EqualTo(user_id));
        }

        [Test]
        [TestCase(5398453)]
        [TestCase(2125474)]
        [TestCase(172625)]
        [TestCase(12010591)]
        [TestCase(11696910)]
        [TestCase(11301721)]
        [TestCase(10869619)]
        public void GetTracks(long user_id)
        {
            var traks = _usersConsole.GetTracks(user_id);
            Assert.NotNull(traks);

            foreach (var track in traks)
            {
                Assert.That(track.UserId, Is.EqualTo(user_id));
                Assert.That(track.User.Id, Is.EqualTo(user_id));
            }
        }
    }
}

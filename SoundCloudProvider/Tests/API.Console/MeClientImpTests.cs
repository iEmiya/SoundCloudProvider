using NUnit.Framework;
using SoundCloudProvider.API.Console;

namespace SoundCloudProvider.Tests.API.Console
{
    [TestFixture]
    public class MeClientImpTests
    {
        private MeClientImp _meConsole;

        [SetUp]
        public void SetUp()
        {
            _meConsole = new MeClientImp(Settings.oAuthTokenDebug);
        }

        [TearDown]
        public void TearDown()
        {
            _meConsole = null;
        }

        [Test]
        public void GetMe()
        {
            var track = _meConsole.GetMe();
            Assert.NotNull(track);
        }
    }
}

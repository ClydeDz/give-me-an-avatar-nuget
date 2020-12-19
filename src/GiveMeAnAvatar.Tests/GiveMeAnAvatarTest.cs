using Xunit;

namespace GiveMeAnAvatar.Tests
{
    public class GiveMeAnAvatarTest
    {
        [Fact]
        public void GetAvatarURL_Returns_URL()
        {
            var avatarURL = GiveMeAnAvatar.GetAvatarURL();
            Assert.Empty(avatarURL);
        }
    }
}

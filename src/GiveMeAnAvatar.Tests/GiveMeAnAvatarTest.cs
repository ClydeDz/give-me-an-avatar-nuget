using Xunit;

namespace GiveMeAnAvatar.Tests
{
    public class GiveMeAnAvatarTest
    {
        [Fact]
        public void GetAvatarURL_Returns_URL()
        {
            var avatarURL = GiveMeAnAvatar.GetAvatarURL();
            Assert.NotEmpty(avatarURL); 
        }

        [Fact]
        public void GetAvatarURL_PassNull_Returns_URL()
        {
            var avatarURL = GiveMeAnAvatar.GetAvatarURL(null);
            Assert.NotEmpty(avatarURL);
        }

        [Fact]
        public void GetAvatarURL_PassSettings_Returns_URL()
        {
            var settings = new AvatarSettings() { Name = "John Echo", Size = 148 };
            var avatarURL = GiveMeAnAvatar.GetAvatarURL(settings);
            Assert.NotEmpty(avatarURL); 
        }

        [Fact]
        public void GetAvatarURL_PassPartialSettings_Returns_URL()
        {
            var settings = new AvatarSettings() { Name = "John Echo" };
            var avatarURL = GiveMeAnAvatar.GetAvatarURL(settings);
            Assert.NotEmpty(avatarURL); 
        }
    }
}

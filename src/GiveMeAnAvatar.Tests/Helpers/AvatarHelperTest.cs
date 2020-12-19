using Xunit;
using GiveMeAnAvatar.Helpers;

namespace GiveMeAnAvatar.Tests.Helpers
{
    public class AvatarHelperTest
    {
        [Fact]
        public void GetDefaultAvatarSettings_Returns_ValidDefaultSettings()
        {
            var defaultAvatarSettings = AvatarHelper.GetDefaultAvatarSettings();
            Assert.NotNull(defaultAvatarSettings);
            Assert.NotEmpty(defaultAvatarSettings.Name);
        }
    }
}

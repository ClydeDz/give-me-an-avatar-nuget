using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

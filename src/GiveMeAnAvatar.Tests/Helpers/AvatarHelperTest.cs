using Xunit;
using GiveMeAnAvatar.Helpers;
using GiveMeAnAvatar.Constants;
using System.Linq;
using GiveMeAnAvatar.Tests.MockData;

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
            Assert.NotNull(defaultAvatarSettings.Size);
            Assert.Empty(defaultAvatarSettings.ExtraFilter);
            Assert.InRange(defaultAvatarSettings.Size.Value, AvatarConstants.AvatarSize.Min, AvatarConstants.AvatarSize.Max-1);
        }

        [Fact]
        public void GetDefaultName_Returns_ValidUserInitials()
        {
            var defaultName = AvatarHelper.GetDefaultName();
            Assert.NotEmpty(defaultName);
            var containsFirstNameInitial = AvatarConstants.Alphabets.Any(x => x.Contains(defaultName.Split("%20")[0]));
            var containsLastNameIntial = AvatarConstants.Alphabets.Any(x => x.Contains(defaultName.Split("%20")[1]));
            Assert.True(containsFirstNameInitial);
            Assert.True(containsLastNameIntial);
        }

        [Fact]
        public void GetDefaultSize_Returns_ValueWithinRange()
        {
            var defaultSize = AvatarHelper.GetDefaultSize();
            Assert.IsType<int>(defaultSize);
            Assert.InRange(defaultSize, AvatarConstants.AvatarSize.Min, AvatarConstants.AvatarSize.Max - 1);
        }

        [Fact]
        public void GetRandomAvatarService_Returns_ValidAvatar()
        {
            var avatar = AvatarHelper.GetRandomAvatarService();
            Assert.NotNull(avatar);
            Assert.NotEmpty(avatar.Key);
            Assert.NotEmpty(avatar.URL);
        }

        [Theory]
        [MemberData(nameof(AvatarHelperTestData.ProcessAvatarTemplate_ExpectValidOutput), MemberType = typeof(AvatarHelperTestData))]
        public void ProcessAvatarTemplate_Returns_ValidAvatarURL(string template, AvatarSettings settings, string expectedOutput)
        {
            var avatar = AvatarHelper.ProcessAvatarTemplate(template, settings);
            Assert.NotNull(avatar);
            Assert.Equal(expectedOutput, avatar); 
        }

        [Theory]
        [MemberData(nameof(AvatarHelperTestData.ProcessAvatarTemplate_ExpectException_Data), MemberType = typeof(AvatarHelperTestData))]
        public void ProcessAvatarTemplate_Expects_Error(string template, AvatarSettings settings)
        {
            Assert.Throws<System.NullReferenceException>(() => 
                AvatarHelper.ProcessAvatarTemplate(template, settings));
        }

        [Fact] 
        public void ValidateAndCleanSettings_OnlySizePassed_ReturnsValidSettings()
        {
            var settings = new AvatarSettings() { Size = 148 };
            var avatarKey = "placeimg.com";
            var avatarSettings = AvatarHelper.ValidateAndCleanSettings(settings, avatarKey);
            Assert.NotNull(avatarSettings);
            Assert.NotEmpty(avatarSettings.Name);
            Assert.Equal(settings.Size, avatarSettings.Size);
        }

        [Fact]
        public void ValidateAndCleanSettings_OnlyNamePassed_ReturnsValidSettings()
        {
            var settings = new AvatarSettings() { Name = "Elton John" };
            var avatarKey = "placeimg.com";
            var avatarSettings = AvatarHelper.ValidateAndCleanSettings(settings, avatarKey);
            Assert.NotNull(avatarSettings);
            Assert.IsType<int>(avatarSettings.Size);
            Assert.Equal("Elton%20John", avatarSettings.Name);
        }

        [Fact]
        public void ValidateAndCleanSettings_NameWithWhitespacePassed_ReturnsValidSettings()
        {
            var settings = new AvatarSettings() { Name = "John David Smith" };
            var avatarKey = "placeimg.com";
            var avatarSettings = AvatarHelper.ValidateAndCleanSettings(settings, avatarKey);
            Assert.NotNull(avatarSettings);
            Assert.IsType<int>(avatarSettings.Size);
            Assert.Equal("John%20David%20Smith", avatarSettings.Name);
        }


        [Fact]
        public void ValidateAndCleanSettings_NullAvatarKeyPassed_ReturnsValidSettings()
        {
            var settings = new AvatarSettings() { Size = 148 }; 
            var avatarSettings = AvatarHelper.ValidateAndCleanSettings(settings, null);
            Assert.NotNull(avatarSettings);
            Assert.IsType<int>(avatarSettings.Size);
            Assert.NotEmpty(avatarSettings.Name);
            Assert.Equal("", avatarSettings.ExtraFilter);
        } 

        [Theory]
        [MemberData(nameof(AvatarHelperTestData.ValidateAndCleanSettings_ExpectException_Data), MemberType = typeof(AvatarHelperTestData))]
        public void ValidateAndCleanSettings_Expects_Error(AvatarSettings settings, string avatarKey)
        {
            Assert.Throws<System.NullReferenceException>(() =>
                AvatarHelper.ValidateAndCleanSettings(settings, avatarKey));           
        }


        [Theory]
        [InlineData("placeimg.com")]
        [InlineData("this_service_does_not_exist")]
        [InlineData(null)]
        public void ApplyExtraFiltersToAvatarURL_DifferentKeyScenarios_ReturnsValidResults(string avatarKey)
        {
            var extraFilters = AvatarHelper.ApplyExtraFiltersToAvatarURL(avatarKey);
            Assert.Empty(extraFilters); 
        } 

        [Fact]
        public void ApplyExtraFiltersToAvatarURL_KeyPassed_ExpectExtraFilterForThatKey()
        {
            var robohashExtraFilterSet = AvatarConstants.ExtraFilterCollection["robohash.org"]; 
            var robohashExtraFilter = AvatarHelper.ApplyExtraFiltersToAvatarURL("robohash.org");
            Assert.NotEmpty(robohashExtraFilter);
            Assert.Contains(robohashExtraFilter, robohashExtraFilterSet);
        }
    }
}

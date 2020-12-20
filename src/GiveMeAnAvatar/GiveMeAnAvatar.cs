using GiveMeAnAvatar.Helpers;

namespace GiveMeAnAvatar
{
    /// <summary>
    /// Service to return a random avatar URL from a collection of different avatar generation services.
    /// </summary>
    public class GiveMeAnAvatar
    {
        /// <summary>
        /// Returns the URL of an avatar that is picked at random.
        /// </summary>
        /// <param name="avatarSettings">You can supply settings to customize the avatar a bit.</param> 
        public static string GetAvatarURL(AvatarSettings avatarSettings = null)
        {
            if (avatarSettings is null)
            {
                avatarSettings = AvatarHelper.GetDefaultAvatarSettings();
            }
            var avatarService = AvatarHelper.GetRandomAvatarService();
            avatarSettings = AvatarHelper.ValidateAndCleanSettings(avatarSettings, avatarService.Key);
            return AvatarHelper.ProcessAvatarTemplate(avatarService.URL, avatarSettings);
        }
    }
}

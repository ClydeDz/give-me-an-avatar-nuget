using GiveMeAnAvatar.Helpers;
using GiveMeAnAvatar.Model;
using System;

namespace GiveMeAnAvatar
{
    public class GiveMeAnAvatar
    {
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

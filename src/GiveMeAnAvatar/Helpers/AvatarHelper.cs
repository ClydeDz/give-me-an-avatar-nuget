using GiveMeAnAvatar.Constants;
using GiveMeAnAvatar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveMeAnAvatar.Helpers
{
    internal class AvatarHelper
    {
        internal static AvatarSettings GetDefaultAvatarSettings()
        {
            return new AvatarSettings
            {
                Name = GetDefaultName(),
                Size = GetDefaultSize(),
                ExtraFilter = ""
            };
        }

        internal static AvatarSettings ValidateAndCleanSettings(AvatarSettings avatarSettings, string avatarKey)
        {
            if (string.IsNullOrEmpty(avatarSettings.Name))
            {
                avatarSettings.Name = GetDefaultName();
            }
            else
            {
                avatarSettings.Name = avatarSettings.Name.Replace(" ", "%20");
            }

            if (!avatarSettings.Size.HasValue)
            {
                avatarSettings.Size = GetDefaultSize();
            }
            if (string.IsNullOrEmpty(avatarSettings.ExtraFilter))
            {
                avatarSettings.ExtraFilter = ApplyExtraFiltersToAvatarURL(avatarKey);
            }
            return avatarSettings;
        }

        internal static AvatarModel GetRandomAvatarService() {
            Random randomGenerator = new Random();
            return AvatarConstants.AvatarCollection[randomGenerator.Next(0, AvatarConstants.AvatarCollection.Count)];
        }

        internal static string ProcessAvatarTemplate(string avatarURLTemplate, AvatarSettings avatarSettings)
        {
            avatarURLTemplate = avatarURLTemplate.Replace("this.Name", "0")
                .Replace("this.Size", "1")
                .Replace("this.ExtraFilter", "2");
            return String.Format(avatarURLTemplate, avatarSettings.Name, avatarSettings.Size, avatarSettings.ExtraFilter);
        }

        internal static string GetDefaultName() {
            Random randomGenerator = new Random();
            string firstName = AvatarConstants.Alphabets[randomGenerator.Next(0, AvatarConstants.Alphabets.Length)];
            string lastName = AvatarConstants.Alphabets[randomGenerator.Next(0, AvatarConstants.Alphabets.Length)];
            return $"{firstName}%20${lastName}";
        }

        internal static int GetDefaultSize() {
            Random randomGenerator = new Random();
            return randomGenerator.Next(AvatarConstants.AvatarSize.Min, AvatarConstants.AvatarSize.Max);
        }

        internal static string ApplyExtraFiltersToAvatarURL(string avatarServiceKey)
        {
            var extraFilter = AvatarConstants.ExtraFilterCollection.Where(element => element.Key == avatarServiceKey);
            if (!extraFilter.Any())
            {
                return "";
            }
            Random randomGenerator = new Random();
            var randomElement = randomGenerator.Next(0, extraFilter.Count());
            return extraFilter.ElementAt(0).Value;
        }
    }
}

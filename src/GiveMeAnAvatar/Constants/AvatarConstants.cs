using GiveMeAnAvatar.Model;
using System.Collections.Generic;

namespace GiveMeAnAvatar.Constants
{
    internal class AvatarConstants
    {
        internal partial class AvatarSize
        {
            internal const int Min = 96;
            internal const int Max = 513;
        }

        internal static readonly string[] Alphabets = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};

        internal static readonly List<AvatarModel> AvatarCollection = new List<AvatarModel>
        {
            new AvatarModel("via.placeholder.com", "https://via.placeholder.com/${this.Size}?text=${this.Name}"),
            new AvatarModel("placeimg.com", "https://placeimg.com/${this.Size}/${this.Size}/people"),
            new AvatarModel("placekitten.com", "https://placekitten.com/g/${this.Size}/${this.Size}"),
            new AvatarModel("dummyimage.com", "https://dummyimage.com/${this.Size}x${this.Size}&text=${this.Name}"),
            new AvatarModel("loremflickr.com", "https://loremflickr.com/${this.Size}/${this.Size}/human"),
            new AvatarModel("baconmockup.com", "https://baconmockup.com/${this.Size}/${this.Size}/"),
            new AvatarModel("placebeard.it", "https://placebeard.it/128"),
            new AvatarModel("fakeimg.pl", "https://fakeimg.pl/${this.Size}x${this.Size}/?text=${this.Name}&font=bebas"),
            new AvatarModel("thispersondoesnotexist.com", "https://thispersondoesnotexist.com/image"),
            new AvatarModel("picsum.photos", "https://picsum.photos/${this.Size}"),
            new AvatarModel("fillmurray.com", "https://www.fillmurray.com/${this.Size}/${this.Size}"),
            new AvatarModel("placecage.com", "https://www.placecage.com/${this.Size}/${this.Size}"),
            new AvatarModel("stevensegallery.com", "https://www.stevensegallery.com/${this.Size}/${this.Size}"),
            new AvatarModel("gravatar.com", "https://www.gravatar.com/avatar/default?s=${this.Size}"),
            new AvatarModel("ui-avatars.com", "https://ui-avatars.com/api/?background=random&size=${this.Size}&name=${this.Name}"),
            new AvatarModel("generative-placeholders.glitch.me", "https://generative-placeholders.glitch.me/image?width=${this.Size}&height=${this.Size}"),
            new AvatarModel("robohash.org", "https://robohash.org/${this.Name}?size=${this.Size}x${this.Size}${this.ExtraFilter}"),
            new AvatarModel("avatars.dicebear.com", "https://avatars.dicebear.com/api${this.ExtraFilter}/${this.Name}.svg?w=${this.Size}&h=${this.Size}"),
            new AvatarModel("avatar.uimaterial.com", "https://avatar.uimaterial.com/?name=${this.Name}&size=${this.Size}${this.ExtraFilter}")
        }; 

        internal static readonly Dictionary<string, List<string>> ExtraFilterCollection = new Dictionary<string, List<string>>
        {
            {"robohash.org", new List<string>(){"&set=set1", "&set=set2", "&set=set3", "&set=set4"}},
            {"avatars.dicebear.com", new List<string>(){ "/gridy", "/human", "/identicon", "/jdenticon", "/avataaars", "/bottts"}},
            {"avatar.uimaterial.com", new List<string>(){ "&setId=8Pfmys5bgfL2NbXFG2sU", "&setId=0496UVJDTqyd2eCIAa46", "&setId=SM2u3518GjohwtHQXNK0", "&setId=Pb7ErSM37KjjIZyJk8w6"}}
        };
    }
}

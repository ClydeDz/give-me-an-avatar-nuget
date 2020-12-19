using GiveMeAnAvatar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        internal static readonly Dictionary<string, string> ExtraFilterCollection = new Dictionary<string, string>
        {
            {"robohash.org", "&set=set1"},
            {"robohash.org", "&set=set2"},
            {"robohash.org", "&set=set3"},
            {"robohash.org", "&set=set4"},
            {"avatars.dicebear.com", "/gridy"},
            {"avatars.dicebear.com", "/human"},
            {"avatars.dicebear.com", "/identicon"},
            {"avatars.dicebear.com", "/jdenticon"},
            {"avatars.dicebear.com", "/avataaars"},
            {"avatars.dicebear.com", "/bottts"},
            {"avatar.uimaterial.com", "&setId=8Pfmys5bgfL2NbXFG2sU"},
            {"avatar.uimaterial.com", "&setId=0496UVJDTqyd2eCIAa46"},
            {"avatar.uimaterial.com", "&setId=SM2u3518GjohwtHQXNK0"},
            {"avatar.uimaterial.com", "&setId=Pb7ErSM37KjjIZyJk8w6"}
        };
    }
}

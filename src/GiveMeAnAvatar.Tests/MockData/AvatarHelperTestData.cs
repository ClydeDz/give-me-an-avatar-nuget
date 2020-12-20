using System.Collections.Generic;

namespace GiveMeAnAvatar.Tests.MockData
{
    class AvatarHelperTestData
    {
        public static IEnumerable<object[]> ProcessAvatarTemplate_ExpectValidOutput()
        { 
            return new List<object[]>
            {
                new object[] { 
                    "https://placeimg.com/${this.Size}/${this.Size}/people", 
                    new AvatarSettings() { Name = "John Echo", Size = 148 }, 
                    "https://placeimg.com/148/148/people" 
                },
                new object[] {
                    "https://robohash.org/${this.Name}?size=${this.Size}x${this.Size}${this.ExtraFilter}",
                    new AvatarSettings() { Name = "Paul", Size = 786, ExtraFilter = "&set=set1"},
                    "https://robohash.org/Paul?size=786x786&set=set1"
                },
                new object[] {
                    "https://placeimg.com/${this.Size}/${this.Size}/people",
                    new AvatarSettings(),
                    "https://placeimg.com///people"
                },
                new object[] {
                    "",
                    new AvatarSettings() { Name = "John Echo", Size = 148 },
                    ""
                }
            };
        }

        public static IEnumerable<object[]> ProcessAvatarTemplate_ExpectException_Data()
        {
            return new List<object[]>
            {
                new object[] {
                    "https://placeimg.com/${this.Size}/${this.Size}/people",
                    null,
                },
                new object[] {
                    null,
                    new AvatarSettings() { Name = "Paul", Size = 786, ExtraFilter = "&set=set1"}
                },
                new object[] {
                    null,
                    null
                }
            };
        }

        public static IEnumerable<object[]> ValidateAndCleanSettings_ExpectException_Data()
        {
            return new List<object[]>
            {
                new object[] {
                    null,
                   "placeimg.com"
                },
                new object[] {
                    null,
                    null
                }
            };
        }
    }
}

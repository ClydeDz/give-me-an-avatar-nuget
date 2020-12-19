using System;

namespace GiveMeAnAvatar.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GiveMeAnAvatar.GetAvatarURL());
            var settings = new AvatarSettings() { Name = "Axel Drew", Size = 124 };
            Console.WriteLine(GiveMeAnAvatar.GetAvatarURL(settings));
        }
    }
}

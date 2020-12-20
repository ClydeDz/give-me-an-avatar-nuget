using System;

namespace GiveMeAnAvatar.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            const string packageName = @"
  _____ _             __  __                                        _             
  / ____(_)           |  \/  |                        /\            | |            
 | |  __ ___   _____  | \  / | ___    __ _ _ __      /  \__   ____ _| |_ __ _ _ __ 
 | | |_ | \ \ / / _ \ | |\/| |/ _ \  / _` | '_ \    / /\ \ \ / / _` | __/ _` | '__|
 | |__| | |\ V |  __/ | |  | |  __/ | (_| | | | |  / ____ \ V | (_| | || (_| | |   
  \_____|_| \_/ \___| |_|  |_|\___|  \__,_|_| |_| /_/    \_\_/ \__,_|\__\__,_|_|   
                                                                                   
                                                                                   
            ";
            
            Console.WriteLine(packageName); 
            Console.WriteLine($"Avatar URL generated without passing any settings: {GiveMeAnAvatar.GetAvatarURL()}");
            var settings = new AvatarSettings() { Name = "Axel Drew", Size = 124 };
            Console.WriteLine($"Avatar URL generated after passing settings: {GiveMeAnAvatar.GetAvatarURL(settings)}");
            Console.ReadLine();
        }
    }
}

<div align="center">
	<br>
	<img width="172" src="https://raw.githubusercontent.com/ClydeDz/give-me-an-avatar-nuget/main/Icon.jpg" alt="Give me an avatar NuGet package icon">
	<br>
	<br>
</div>  

# Give Me an Avatar
Gets a random avatar URL from a collection of different avatar generation services.  

[![Azure DevOps builds](https://img.shields.io/azure-devops/build/clydedsouza-nuget/03b052e2-ef54-44b2-82b3-3c3a1e09d864/10?logo=Azure%20DevOps)](https://dev.azure.com/clydedsouza-nuget/Give%20Me%20an%20Avatar%20NuGet/_build) 
[![Azure DevOps tests](https://img.shields.io/azure-devops/tests/clydedsouza-nuget/Give%2520Me%2520an%2520Avatar%2520NuGet/10?logo=Azure%20DevOps)](https://dev.azure.com/clydedsouza-nuget/Give%20Me%20an%20Avatar%20NuGet/_build) 
[![Nuget](https://img.shields.io/nuget/v/GiveMeAnAvatar?color=brightgreen&logo=NuGet)](https://www.nuget.org/packages/GiveMeAnAvatar) 
[![Nuget](https://img.shields.io/nuget/dt/GiveMeAnAvatar?color=brightgreen&logo=NuGet)](https://www.nuget.org/packages/GiveMeAnAvatar)      

## Installation and usage
Library can either be directly downloaded from [Nuget.org](https://www.nuget.org/packages/GiveMeAnAvatar), OR installed via the [NuGet Package Manager UI](https://docs.microsoft.com/en-us/nuget/tools/package-manager-ui#finding-and-installing-a-package) or via the [Package Manager Console](https://docs.microsoft.com/en-us/nuget/tools/package-manager-console) if you're using Visual Studio.

Command to install Give Me an Avatar NuGet via the Package Manager Console UI in Visual Studio shown below.
```PowerShell
PM> Install-Package GiveMeAnAvatar
```

Include the namespace in your program.
```C#
using GiveMeAnAvatar;
```

Then go ahead and consume it.
```C#
var avatarURL= GiveMeAnAvatar.GetAvatarURL();
``` 
  
Or supply optional settings to get a slightly customized avatar URL.
```C#
var settings = new AvatarSettings() { Name = "John Smith", Size = 124 };
var avatarURL= GiveMeAnAvatar.GetAvatarURL(settings);
``` 

    

## Supported avatar services

| Service                                    | Avatar example                                       |
|--------------------------------------------|------------------------------------------------------|
| [placeholder.com](https://placeholder.com) | ![image](https://via.placeholder.com/128?Text=J%20S) |
| [placeimg.com](https://placeimg.com)       | ![image](https://placeimg.com/128/128/people)        |
| [placekitten.com](https://placekitten.com) | ![image](https://placekitten.com/g/128/128?cache=invalidate-nuget)          |
| [dummyimage.com](https://dummyimage.com/)  | ![image](https://dummyimage.com/128x128&text=J%20S)  |
| [loremflickr.com](https://loremflickr.com) | ![image](https://loremflickr.com/128/128/human)      |
| [baconmockup.com](https://baconmockup.com) | ![image](https://baconmockup.com/128/128/)           |
| [placebeard.it](https://placebeard.it)     | ![image](https://placebeard.it/128)                  |
| [fakeimg.pl](https://fakeimg.pl)           | ![image](https://fakeimg.pl/128x128/?text=John%20Smith&font=bebas)   |
| [thispersondoesnotexist.com](https://thispersondoesnotexist.com/) | <img src="https://thispersondoesnotexist.com/image" width="128"/> |
| [picsum.photos](https://picsum.photos/)     | ![image](https://picsum.photos/128)                  |
| [fillmurray.com](https://www.fillmurray.com)     | ![image](https://www.fillmurray.com/128/128)    |
| [placecage.com](https://www.placecage.com)       | ![image](https://www.placecage.com/128/128)     |
| [stevensegallery.com](https://www.stevensegallery.com)       | ![image](https://www.stevensegallery.com/128/128)  |
| [gravatar.com](https://www.gravatar.com)    | ![image](https://www.gravatar.com/avatar/default?s=128)     |
| [ui-avatars.com](https://www.ui-avatars.com)    | ![image](https://ui-avatars.com/api/?background=random&size=128&name=J%20S)     |
| [generative-placeholders.glitch.me](https://generative-placeholders.glitch.me)       | ![image](https://generative-placeholders.glitch.me/image?width=128&height=128)     |
| [robohash.org](https://robohash.org)       | ![image](https://robohash.org/John%20Smith?size=128x128&set=set1) ![image](https://robohash.org/John%20Smith?size=128x128&set=set2) ![image](https://robohash.org/John%20Smith?size=128x128&set=set3) ![image](https://robohash.org/John%20Smith?size=128x128&set=set4)     |
| [avatars.dicebear.com](https://avatars.dicebear.com)     | ![image](https://avatars.dicebear.com/4.5/api/gridy/John%20Smith.svg?w=128&h=128) ![image](https://avatars.dicebear.com/4.5/api/human/John%20Smith.svg?w=128&h=128) ![image](https://avatars.dicebear.com/4.5/api/identicon/John%20Smith.svg?w=128&h=128) ![image](https://avatars.dicebear.com/4.5/api/jdenticon/John%20Smith.svg?w=128&h=128) ![image](https://avatars.dicebear.com/4.5/api/avataaars/John%20Smith.svg?w=128&h=128)  ![image](https://avatars.dicebear.com/4.5/api/bottts/John%20Smith.svg?w=128&h=128)             |
| [avatar.uimaterial.com](https://avatar.uimaterial.com)     | ![image](https://avatar.uimaterial.com/?setId=0496UVJDTqyd2eCIAa46&name=John%20Smith&size=128) ![image](https://avatar.uimaterial.com/?setId=8Pfmys5bgfL2NbXFG2sU&name=John%20Smith&size=128) ![image](https://avatar.uimaterial.com/?setId=SM2u3518GjohwtHQXNK0&name=John%20Smith&size=128) ![image](https://avatar.uimaterial.com/?setId=Pb7ErSM37KjjIZyJk8w6&name=John%20Smith&size=128)   |

## Notes
* I'm not using [avataaars](https://avataaars.io/) separately since [avatars.dicebear.com](https://avatars.dicebear.com) includes avataaars.    
* Placekitten image might appear broken at times in the table above, however, the image service itself runs fine.     

## Credits   
- All the avatar services used in this NuGet package are outlined in the table above.    
- Package logo created using [AutoDraw](https://www.autodraw.com/).   
- This NuGet package is developed by [Clyde D'Souza](https://twitter.com/clydedz).
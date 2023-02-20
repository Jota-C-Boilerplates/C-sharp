# C-sharp-basic-syntax
## Intro
- .Net: Free. Cross-platform. Open source. A developer platform for building deskop, web, cloud, mobile, gamming, IoT and AI apps
- MSIL: MS Intermedita language is a general compiler for F# compiler, C# compailer and VB compailer
- C# evolution:
  - .Net Runtime 4: From C# 4.0 to C# 7.3
  - .Net Runtime runs MSIL
- .Net Core
  - Brings cross-platform runtimes
  - Simplifing deployment, because we can run two runtimes version in the same server (only with .Net core)

## Base Class Library
- Libraries for everything: Dates, Math, Strings, File IO, Data Access, TCP, SMTP, HTTP, Arrays, Collctions, Security, XML, JSON, etc.
- Create custom Libraries
- Use Third-Party Libraries using NuGet
  - Nuget: Shared libraries and version control. Single source. Security. Open Platform and Install lifecycle.
  - Each Nuget Library (.dll) has metadata for version and source
  
## C#
- C# is a statically-typed, object-oriented language used with the .Net frameworks and runtimes.
- A .Net Runtime is a colllection of commands native to the compute operative system that instruct the computer how to interpret and run a .Net Program. There are several differente .Net runtimes:
  - .Net Framework - runs on Windows and support desktop UI, console and server developement
  - .Net Core - runds on Windows, Mac and Linux and support desktop UI, console and server developement
  - Xamarin - runds on iOS and Android devices with support for native application development on those devices
  - Unity - runs on Windows, Mac, Linux, iOS and Android devices with support for game development using the Unitiy3D Tools
  - Mono- runs on Windows, Mac, Linux and Web Assembly
- A .Net framework is a collection of programming instructions and tools that help you write program of a specific type of application (Windows Forms, ASP.Net Core, Brazor, etc)
- The definiton of the framework and runtime for a C# program are stored in a `.csproj` file. C# project file (important for building C# program). It's the equivalent to the manifest file in Java.
- `.cs` general extension of a C# file
- `.cshtml` razor pages extension
- C# IS case-sensitive: All variables, objects and their interactions must be referenced with the proper casing.

## Resources
- https://learn.microsoft.com/en-us/dotnet/csharp/
- https://learn.microsoft.com/en-us/training/paths/csharp-first-steps/?WT.mc_id=dotnet-35129-website

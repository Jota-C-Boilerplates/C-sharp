## .Net 
- .Net: Free. Cross-platform. Open source. A developer platform for building deskop, web, cloud, mobile, gamming, IoT and AI apps
- .Net Core
  - Brings cross-platform runtimes
  - Simplifing deployment, because we can run two runtimes version in the same server (only with .Net core)
- C# programs run on .NET, a virtual execution system called the common language runtime (CLR) and a set of class libraries. The CLR is the implementation by Microsoft of the common language infrastructure (CLI), an international standard. The CLI is the basis for creating execution and development environments in which languages and libraries work together seamlessly.
- Source code written in C# is compiled into an intermediate language (IL) that conforms to the CLI specification. The IL code and resources, such as bitmaps and strings, are stored in an assembly, typically with an extension of .dll. An assembly contains a manifest that provides information about the assembly's types, version, and culture. IL Intermedita language is the general compiler for F# compiler, C# compiler and VB compiler
- When the C# program is executed, the assembly is loaded into the CLR. The CLR performs Just-In-Time (JIT) compilation to convert the IL code to native machine instructions. The CLR provides other services related to automatic garbage collection, exception handling, and resource management. Code that's executed by the CLR is sometimes referred to as "managed code." "Unmanaged code," is compiled into native machine language that targets a specific platform.
- Language interoperability is a key feature of .NET. IL code produced by the C# compiler conforms to the Common Type Specification (CTS). IL code generated from C# can interact with code that was generated from the .NET versions of F#, Visual Basic, C++. There are more than 20 other CTS-compliant languages. A single assembly may contain multiple modules written in different .NET languages. The types can reference each other as if they were written in the same language.
- System.Console.WriteLine or shorthand (Console.WriteLine): The output of the program is produced by the WriteLine method of the Console class in the System namespace. This class is provided by the standard class libraries, which, by default, are automatically referenced by the compiler.


## Base Class Library
- Libraries for everything: Dates, Math, Strings, File IO, Data Access, TCP, SMTP, HTTP, Arrays, Collctions, Security, XML, JSON, etc.
- Create custom Libraries
- Use Third-Party Libraries using NuGet
  - Nuget: Shared libraries and version control. Single source. Security. Open Platform and Install lifecycle.
  - Each Nuget Library (.dll) has metadata for version and source
  
## C#
- C# evolution:
  - .Net Runtime 4: From C# 4.0 to C# 7.3
  - .Net Runtime runs MSIL
- C# is a statically-typed, object-oriented language, component-oriented programming language used with the .Net frameworks and runtimes.
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
- Several C# features help create robust and durable applications. 
  - Garbage collection automatically reclaims memory occupied by unreachable unused objects. 
  - Nullable types guard against variables that don't refer to allocated objects. 
  - Exception handling provides a structured and extensible approach to error detection and recovery. 
  - Lambda expressions support functional programming techniques. 
  - Language Integrated Query (LINQ) syntax creates a common pattern for working with data from any source. 
  - Language support for asynchronous operations provides syntax for building distributed systems. 
  - C# has a unified type system. All C# types, including primitive types such as int and double, inherit from a single root object type. 
  - All types share a set of common operations. Values of any type can be stored, transported, and operated upon in a consistent manner. 
  - Furthermore, C# supports both user-defined reference types and value types. 
  - C# allows dynamic allocation of objects and in-line storage of lightweight structures. 
  - C# supports generic methods and types, which provide increased type safety and performance. 
  - C# provides iterators, which enable implementers of collection classes to define custom behaviors for client code.

## Resources
- https://learn.microsoft.com/en-us/dotnet/csharp/
- https://learn.microsoft.com/en-us/training/paths/csharp-first-steps/?WT.mc_id=dotnet-35129-website
- https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/

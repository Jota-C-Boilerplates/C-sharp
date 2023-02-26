### Nullable types
Variables of any type may be declared as non-nullable
or nullable. A nullable variable can hold an additional 
null value, indicating ==no value==. 
Nullable Value types (structs or enums) are represented 
by `System.Nullable<T>`. 
Non-nullable and Nullable Reference types are both 
represented by the underlying reference type. 
The distinction is represented by metadata read by 
the compiler and some libraries. 
==The compiler provides warnings when nullable references 
are dereferenced without first checking their value 
against null. The compiler also provides warnings 
when non-nullable references are assigned a value that 
may be null.== 

We can use default:

``
int? optionalInt = default; 
``

### Resources
https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types

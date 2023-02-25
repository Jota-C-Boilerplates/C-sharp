## Value Types
C#'s value types are further divided into simple types, enum types, struct types, nullable value types, and tuple value types.
Value types
- Simple types
  - Signed integral: sbyte, short, int, long
  - Unsigned integral: byte, ushort, uint, ulong
  - Unicode characters: char, which represents a UTF-16 code unit
  - IEEE binary floating-point: float, double
  - High-precision decimal floating-point: decimal
  - Boolean: bool, which represents Boolean values—values that are either true or false
- Enum types
  - User-defined types of the form enum E {...}. An enum type is a distinct type with named constants. Every enum type has an underlying type, which must be one of the eight integral types. The set of values of an enum type is the same as the set of values of the underlying type.
- Struct types
  - User-defined types of the form struct S {...}
- Nullable value types
  - Extensions of all other value types with a null value
- Tuple value types
  - User-defined types of the form (T1, T2, ...)

## Reference Types
C#'s reference types are further divided into class types, interface types, array types, and delegate types.
Reference types
- Class types
  - Ultimate base class of all other types: object
  - Unicode strings: string, which represents a sequence of UTF-16 code units
  - User-defined types of the form class C {...}
- Interface types
  - User-defined types of the form interface I {...}
- Array types
  - Single-dimensional, multi-dimensional, and jagged. For example: int[], int[,], and int[][]
- Delegate types
  - User-defined types of the form delegate int D(...)

You can also declare record types, either record struct, or record class. Record types have compiler-synthesized members. You use records primarily for storing values, with minimal associated behavior.

***

## Types and Generics
### Class
A class type defines a data structure that contains data members (fields) and function members (methods, properties, and others). 
Class types support single inheritance and polymorphism, mechanisms whereby derived classes can extend and specialize base classes.

### Struct
A struct type is similar to a class type in that it represents a structure with data members and function members. 
However, unlike classes, structs are value types and don't typically require heap allocation. 
Struct types don't support user-specified inheritance, and all struct types implicitly inherit from type object.

### Interface
An interface type defines a contract as a named set of public members. 
A class or struct that implements an interface must provide implementations of the interface's members. 
An interface may inherit from multiple base interfaces, and a class or struct may implement multiple interfaces.

### Delegate
A delegate type represents references to methods with a particular parameter list and return type. 
Delegates make it possible to treat methods as entities that can be assigned to variables and passed as parameters. 
Delegates are analogous to function types provided by functional languages. 
They're also similar to the concept of function pointers found in some other languages. 
Unlike function pointers, delegates are object-oriented and type-safe.

The class, struct, interface, and delegate types all support generics, whereby they can be parameterized with other types.

***

## Nullabe
Nullable types don't require a separate definition. For each non-nullable type T, 
there's a corresponding nullable type T?, which can hold an additional value, null. 
For instance, int? is a type that can hold any 32-bit integer or the value null, 
and string? is a type that can hold any string or the value null.

## Arrays
C# supports single-dimensional and multi-dimensional arrays of any type. 
Unlike the types listed above, array types don't have to be declared before they can be used. 
Instead, array types are constructed by following a type name with square brackets. 
For example, int[] is a single-dimensional array of int, 
int[,] is a two-dimensional array of int, 
and int[][] is a single-dimensional array of single-dimensional arrays, or a "jagged" array, of int.

## Object
C#'s type system is unified such that a value of any type can be treated as an object. 
Every type in C# directly or indirectly derives from the object class type, and object is the ultimate 
base class of all types. Values of reference types are treated as objects simply by viewing the values 
as type object. Values of value types are treated as objects by performing boxing and unboxing operations.

***

## Program structure
The key organizational concepts in C# are programs, namespaces, types, members, and assemblies. 
Programs declare types, which contain members and can be organized into namespaces. 
Classes, structs, and interfaces are examples of types. 
Fields, methods, properties, and events are examples of members. 
When C# programs are compiled, they're physically packaged into assemblies. 
Assemblies typically have the file extension .exe or .dll, depending on whether they implement 
applications or libraries, respectively.


## Resources
- https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/
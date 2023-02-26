## OOP
### OPP, Classes, Structs and Records
As an object-oriented language, C# supports the concepts of encapsulation, inheritance, 
and polymorphism. ==A class== may inherit directly from one parent class, and it may implement 
any number of ==interfaces==. Methods that ==override virtual methods== in a parent class require 
the override keyword as a way to avoid accidental redefinition. In C#, ==a struct== is like a 
lightweight class; it's a stack-allocated type that can implement interfaces but ==doesn't 
support inheritance==. C# provides ==record class and record struct== types, which are types whose 
purpose is ==primarily storing data values==.

### Classes and Objects
Classes are the most fundamental of C#'s types. A class is a data structure that combines state 
(fields) and actions (methods and other function members) in a single unit. A class provides a
definition for instances of the class, also known as objects. Classes support inheritance and 
polymorphism, mechanisms whereby derived classes can extend and specialize base classes.

New classes are created using class declarations. A class declaration starts with a header. 
The header specifies:
- The attributes and modifiers of the class
- The name of the class
- The base class (when inheriting from a base class)
- The interfaces implemented by the class.

### Types parameters
Generic classes define type parameters. Type parameters 
are a list of type parameter names enclosed in angle 
brackets. Type parameters follow the class name. 
The type parameters can then be used in the body of the 
class declarations to define the members of the class. 
In the following example, the type parameters of Pair 
are TFirst and TSecond:

[TypeParameters_Pair.cs](./TypeParameters_Pair.cs)

### Base classes
A class declaration may specify a base class. Follow 
the class name and type parameters with a colon and 
the name of the base class. Omitting a base class 
specification is the same as deriving from type object.
A class inherits the members of its base class. 
Inheritance means that a class implicitly contains 
almost all members of its base class. A class doesn't 
inherit the instance and static constructors, and the 
finalizer. A derived class can add new members to those 
members it inherits, but it can't remove the definition
of an inherited member. In the example, Point3D inherits
the X and Y members from Point, and every Point3D 
instance contains three properties, X, Y, and Z.

An implicit conversion exists from a class
type to any of its base class types. A variable of a 
class type can reference an instance of that class 
or an instance of any derived class. For example, 
given the previous class declarations, a variable of 
type Point can reference either a Point or a Point3D:

[InheritClass_Point3D.cs](./InheritClass_Point3D.cs)

### Structs
Classes define types that support inheritance and 
polymorphism. They enable you to create sophisticated 
behaviors based on hierarchies of derived classes. 
By contrast, struct types are simpler types whose 
primary purpose is to store data values. Structs 
can't declare a base type; they implicitly derive 
from `System.ValueType`. You can't derive other struct
types from a struct type. They're implicitly sealed.

[Struct_Point.cs](./Struct_Point.cs)

### Interfaces
An interface defines a contract that can be implemented 
by classes and structs. You define an interface to 
declare capabilities that are shared among distinct 
types. For example, the `System.Collections.Generic.IEnumerable<T>` 
interface defines a consistent way to traverse all 
the items in a collection, such as an array. 
An interface can contain methods, properties, events, 
and indexers. ==An interface typically doesn't provide 
implementations of the members it defines—it merely 
specifies the members that must be supplied by classes 
or structs that implement the interface.==

Interfaces may employ multiple inheritance. In the 
following example, the interface IComboBox inherits 
from both ITextBox and IListBox.

When a class or struct implements a particular interface,
instances of that class or struct can be implicitly 
converted to that interface type

[Interfaces_EditBox.cs](./Interfaces_EditBox.cs)

### Resources
https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types

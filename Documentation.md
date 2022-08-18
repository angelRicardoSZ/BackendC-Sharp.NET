Documentation

## [Built-in types]([Built-in types - C# reference | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types))

### bool 

The bool keyword is an alias for the .NET System.Boolean structure type that represents a Boolean value that can be true or false.

Example:

```c#
bool check = true;
Console.WriteLine(check ? "Checked" : "Not checked");  // output: Checked

Console.WriteLine(false ? "Checked" : "Not checked");  // output: Not checked
```

### Integral numeric types

The *integral numeric types* represent integer numbers. All integral numeric types are [value types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types). They're also [simple types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types#built-in-value-types) and can be initialized with [literals](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types#integer-literals). All integral numeric types support [arithmetic](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators), [bitwise logical](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators), [comparison](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/comparison-operators), and [equality](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/equality-operators) operators.

C# supports the following predefined integral types:

| C# type/keyword | Range                                                   | Size                              | .NET type                                                    |
| --------------- | ------------------------------------------------------- | --------------------------------- | ------------------------------------------------------------ |
| `sbyte`         | -128 to 127                                             | Signed 8-bit integer              | [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/system.sbyte) |
| `byte`          | 0 to 255                                                | Unsigned 8-bit integer            | [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte) |
| `short`         | -32,768 to 32,767                                       | Signed 16-bit integer             | [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/system.int16) |
| `ushort`        | 0 to 65,535                                             | Unsigned 16-bit integer           | [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/system.uint16) |
| `int`           | -2,147,483,648 to 2,147,483,647                         | Signed 32-bit integer             | [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32) |
| `uint`          | 0 to 4,294,967,295                                      | Unsigned 32-bit integer           | [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/system.uint32) |
| `long`          | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 | Signed 64-bit integer             | [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64) |
| `ulong`         | 0 to 18,446,744,073,709,551,615                         | Unsigned 64-bit integer           | [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/system.uint64) |
| `nint`          | Depends on platform (computed at runtime)               | Signed 32-bit or 64-bit integer   | [System.IntPtr](https://docs.microsoft.com/en-us/dotnet/api/system.intptr) |
| `nuint`         | Depends on platform (computed at runtime)               | Unsigned 32-bit or 64-bit integer | [System.UIntPtr](https://docs.microsoft.com/en-us/dotnet/api/system.uintptr) |

In all of the table rows except the last two, each C# type keyword from the leftmost column is an alias for the corresponding .NET type. The keyword and .NET type name are interchangeable. For example, the following declarations declare variables of the same type:

```C#
int a = 123;
System.Int32 b = 123;
```

### Integer literals

Integer literals can be

- *decimal*: without any prefix
- *hexadecimal*: with the `0x` or `0X` prefix
- *binary*: with the `0b` or `0B` prefix (available in C# 7.0 and later)

```C#
var decimalLiteral = 42;
var hexLiteral = 0x2A;
var binaryLiteral = 0b_0010_1010;
```

The preceding example also shows the use of `_` as a *digit separator*, which is supported starting with C# 7.0. You can use the digit separator with all kinds of numeric literals.

### char 

The `char` type keyword is an alias for the .NET [System.Char](https://docs.microsoft.com/en-us/dotnet/api/system.char) structure type that represents a Unicode UTF-16 character.

The default value of the `char` type is `\0`, that is, U+0000.

The `char` type supports [comparison](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/comparison-operators), [equality](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/equality-operators), [increment](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#increment-operator-), and [decrement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#decrement-operator---) operators. Moreover, for `char` operands, [arithmetic](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators) and [bitwise logical](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators) operators perform an operation on the corresponding character codes and produce the result of the `int` type.

The [string](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types#the-string-type) type represents text as a sequence of `char` values.

### Literals

You can specify a `char` value with:

- a character literal.
- a Unicode escape sequence, which is `\u` followed by the four-symbol hexadecimal representation of a character code.
- ### a hexadecimal escape sequence, which is `\x` followed by the hexadecimal representation of a character code.

```c#
var chars = new[]
{
    'j',
    '\u006A',
    '\x006A',
    (char)106,
};
Console.WriteLine(string.Join(" ", chars));  // output: j j j j
```

### Object

The `object` type is an alias for [System.Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) in .NET. In the unified type system of C#, all types, predefined and user-defined, reference types and value types, inherit directly or indirectly from [System.Object](https://docs.microsoft.com/en-us/dotnet/api/system.object). You can assign values of any type to variables of type `object`. Any `object` variable can be assigned to its default value using the literal `null`. When a variable of a value type is converted to object, it's said to be *boxed*. When a variable of type `object` is converted to a value type, it's said to be *unboxed*. For more information, see [Boxing and Unboxing](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing).

#### Boxing and Unboxing 

Boxing is the process of converting a [value type](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types) to the type `object` or to any interface type implemented by this value type. In the following example, the integer variable `i` is *boxed* and assigned to object `o`.

```c#
int i = 123;
// The following line boxes i.
object o = i;
```

The object `o` can then be unboxed and assigned to integer variable `i`:

```c#
o = 123;
i = (int)o;  // unboxing
```

#### String 

The `string` type represents a sequence of zero or more Unicode characters. `string` is an alias for [System.String](https://docs.microsoft.com/en-us/dotnet/api/system.string) in .NET.

Although `string` is a reference type, the [equality operators `==` and `!=`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/equality-operators#string-equality) are defined to compare the values of `string` objects, not references. Value based equality makes testing for string equality more intuitive. For example:

```c#
string a = "hello";
string b = "h";
// Append to contents of 'b'
b += "ello";
Console.WriteLine(a == b);
Console.WriteLine(object.ReferenceEquals(a, b));
```

Strings are *immutable*--the contents of a string object can't be changed after the object is created, although the syntax makes it appear as if you can. For example, when you write this code, the compiler actually creates a new string object to hold the new sequence of characters, and that new object is assigned to `b`. The memory that had been allocated for `b` (when it contained the string "h") is then eligible for garbage collection.

```c#
string b = "h";
b += "ello";
```

The `[]` [operator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#indexer-operator-) can be used for readonly access to individual characters of a string. Valid index values start at `0` and must be less than the length of the string:

```c#
string str = "test";
char x = str[2];  // x = 's';
```

## Conversions

- implicit: no special syntax is required because the conversion is always correct and no data will be lost. examples include conversions from smaller to larger integer types and conversions from derived classes to base classes.

- Explicit: require a Cast expression. Conversion is necessary if it is possible that information is lost in the conversion, or when it is possible that the conversion is not correct for other reasons. Typical examples include numerical conversion to a type that has less precision or a smaller interval, and conversion of a base class instance to a derived class.

  A conversion expression in the format (T) E performs an explicit conversion of the result of expression E to type T.

  ```c#
  double x = 1234.7;
  int a = (int)x;
  Console.WriteLine(a);   // output: 1234
  
  IEnumerable<int> numbers = new int[] { 10, 20, 30 };
  IList<int> list = (IList<int>)numbers;
  Console.WriteLine(list.Count);  // output: 3
  Console.WriteLine(list[1]);  // output: 20
  ```

### Convert Char to Int in C#

#### `Char.GetNumericValue()`

Converts the specified numeric Unicode character to a double-precision floating point number. If the method is applied on a `char` variable with numeric value enclosed in single quotes, that number is returned, else -1 is returned.

```c#
public static double GetNumericValue (char c);
```

The Unicode character to convert.

```c#
using System;

public class GetNumericValueSample {
    public static void Main() {
        string str = "input: 1";

        Console.WriteLine(Char.GetNumericValue('8'));		// Output: "8"
        Console.WriteLine(Char.GetNumericValue(str, 7));	// Output: "1"
    }
}
```

### Convert.ToInt32()

The `Convert.ToInt32()` function, converts a specified value to a 32-bit signed integer. The `ToInt32()` method has so many variants depending on the data type of the argument passed.

If the `char` data type is passed as an argument into the `Convert.Tolnt32()` method, the `ASCII` equivalent is returned.

```c#
string[] values = { "One", "1.34e28", "-26.87", "-18", "-6.00",
                    " 0", "137", "1601.9", Int32.MaxValue.ToString() };
int result;

foreach (string value in values)
{
   try {
      result = Convert.ToInt32(value);
      Console.WriteLine("Converted the {0} value '{1}' to the {2} value {3}.",
                        value.GetType().Name, value, result.GetType().Name, result);
   }
   catch (OverflowException) {
      Console.WriteLine("{0} is outside the range of the Int32 type.", value);
   }
   catch (FormatException) {
      Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                        value.GetType().Name, value);
   }
}
// The example displays the following output:
//    The String value 'One' is not in a recognizable format.
//    The String value '1.34e28' is not in a recognizable format.
//    The String value '-26.87' is not in a recognizable format.
//    Converted the String value '-18' to the Int32 value -18.
//    The String value '-6.00' is not in a recognizable format.
//    Converted the String value ' 0' to the Int32 value 0.
//    Converted the String value '137' to the Int32 value 137.
//    The String value '1601.9' is not in a recognizable format.
//    Converted the String value '2147483647' to the Int32 value 2147483647.
```

#### Int32.Parse(String)

Is used to convert the string representation of a number to its 32-bit signed integer equivalent.

```c#
public static int Parse (string str);
```

**Return Value:** It is a 32-bit signed integer equivalent to the number contained in *str*.

**Exceptions:**

- **ArgumentNullException**: If *str* is null.
- **FormatException**: If *str* is not in the correct format.
- **OverflowException**: If *str* represents a number less than *[MinValue ](https://www.geeksforgeeks.org/int32-minvalue-field-in-c-sharp-with-examples/)*or greater than *[MaxValue](https://www.geeksforgeeks.org/int32-maxvalue-field-in-c-sharp-with-examples/)*.

```c#
// C# program to demonstrate
// Int32.Parse(String) Method
using System;

class GFG {

	// Main Method
	public static void Main()
	{

		// passing different values
		// to the method to check
		checkParse("2147483647");
		checkParse("214,7483,647");
		checkParse("-2147483");
		checkParse(" 2183647 ");
	}

	// Defining checkParse method
	public static void checkParse(string input)
	{

		try {

			// declaring Int32 variable
			int val;

			// getting parsed value
			val = Int32.Parse(input);
			Console.WriteLine("'{0}' parsed as {1}", input, val);
		}

		catch (FormatException) {
			Console.WriteLine("Can't Parsed '{0}'", input);
		}
	}
}
```

```bash
'2147483647' parsed as 2147483647
Can't Parsed '214,7483,647'
'-2147483' parsed as -2147483
' 2183647 ' parsed as 2183647
```

## Arrays

You can store multiple variables of the same type in an array data structure. if you want the array to store items of any type you can specify object as its type

```c#
type[] arrayName;
```

```c#
class TestArraysClass
{
    static void Main()
    {
        // Declare a single-dimensional array of 5 integers.
        int[] array1 = new int[5];

        // Declare and set array element values.
        int[] array2 = new int[] { 1, 3, 5, 7, 9 };

        // Alternative syntax.
        int[] array3 = { 1, 2, 3, 4, 5, 6 };

        // Declare a two dimensional array.
        int[,] multiDimensionalArray1 = new int[2, 3];

        // Declare and set array element values.
        int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        // Declare a jagged array.
        int[][] jaggedArray = new int[6][];

        // Set the values of the first array in the jagged array structure.
        jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
    }
}
```

### Multidimensional  arrays

 The following statement creates a two-dimensional array of four rows and two columns.

```c#
int[,] array = new int[4, 2];
```

The following statement creates a three-dimensional matrix, 4, 2, and 3.

```c#
int[,,] array1 = new int[4, 2, 3];
```

## List

To initialize a list in C#, the keyword List is used, followed by the type of data that will contain that list between the symbols <>. Next, we must use the List constructor as if it were any other C# object.

```c#
List<string> personNames = new List<string>();
```

## General Structure of a C# program

C# programs consist of one or more files. Each file contains zero or more namespaces. A namespace contains types such as classes, structs, interfaces, enumerations, and delegates, or other namespaces. The following example is the skeleton of a C# program that contains all of these elements.

```c#
// A skeleton of a C# program
using System;

// Your program starts here:
Console.WriteLine("Hello world!");

namespace YourNamespace
{
    class YourClass
    {
    }

    struct YourStruct
    {
    }

    interface IYourInterface
    {
    }

    delegate int YourDelegate();

    enum YourEnum
    {
    }

    namespace YourNestedNamespace
    {
        struct YourStruct
        {
        }
    }
}
```

The preceding example uses *top-level statements* for the program's entry point. This feature was added in C# 9. Prior to C# 9, the entry point was a static method named `Main`, as shown in the following example:

```c#
// A skeleton of a C# program
using System;
namespace YourNamespace
{
    class YourClass
    {
    }

    struct YourStruct
    {
    }

    interface IYourInterface
    {
    }

    delegate int YourDelegate();

    enum YourEnum
    {
    }

    namespace YourNestedNamespace
    {
        struct YourStruct
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Your program starts here...
            Console.WriteLine("Hello world!");
        }
    }
}
```

#### classes

A type that is defined as a [`class`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class) is a *reference type*. At run time, when you declare a variable of a reference type, the variable contains the value [`null`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null) until you explicitly create an instance of the class by using the [`new`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/new-operator) operator, or assign it an object of a compatible type that may have been created elsewhere, as shown in the following example:

```c#
//Declaring an object of type MyClass.
MyClass mc = new MyClass();

//Declaring another object of the same type, assigning it the value of the first object.
MyClass mc2 = mc;
```

When the object is created, enough memory is allocated on the managed heap for that specific object, and the variable holds only a reference to the location of said object. Types on the managed heap require overhead both when they are allocated and when they are reclaimed by the automatic memory management functionality of the CLR, which is known as *garbage collection*. However, garbage collection is also highly optimized and in most scenarios, it does not create a performance issue. For more information about garbage collection, see [Automatic memory management and garbage collection](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/fundamentals).

#### Declaring Classes

Classes are declared by using the `class` keyword followed by a unique identifier, as shown in the following example:

```c#
//[access modifier] - [class] - [identifier]
public class Customer
{
   // Fields, properties, methods and events go here...
}
```

The `class` keyword is preceded by the access level. Because [`public`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/public) is used in this case, anyone can create instances of this class. The name of the class follows the `class` keyword. The name of the class must be a valid C# [identifier name](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names). The remainder of the definition is the class body, where the behavior and data are defined. Fields, properties, methods, and events on a class are collectively referred to as *class members*.

#### Creating objects

Although they are sometimes used interchangeably, a class and an object are different things. A class defines a type of object, but it is not an object itself. An object is a concrete entity based on a class, and is sometimes referred to as an instance of a class.

Objects can be created by using the `new` keyword followed by the name of the class that the object will be based on, like this:

```c#
Customer object1 = new Customer();
```

When an instance of a class is created, a reference to the object is passed back to the programmer. In the previous example, `object1` is a reference to an object that is based on `Customer`. This reference refers to the new object but does not contain the object data itself. In fact, you can create an object reference without creating an object at all:

```
Customer object2;
```

We don't recommend creating object references such as the preceding one that don't refer to an object because trying to access an object through such a reference will fail at run time. However, such a reference can be made to refer to an object, either by creating a new object, or by assigning it an existing object, such as this:

```c#
Customer object3 = new Customer();
Customer object4 = object3;
```

This code creates two object references that both refer to the same object. Therefore, any changes to the object made through `object3` are reflected in subsequent uses of `object4`. Because objects that are based on classes are referred to by reference, classes are known as reference types.

## Constructors 

Whenever a [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class) or [struct](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct) is created, its constructor is called. A class or struct may have multiple constructors that take different arguments. Constructors enable the programmer to set default values, limit instantiation, and write code that is flexible and easy to read. 

### Constructor syntax

A constructor is a method whose name is the same as the name of its type. Its method signature includes only an optional [access modifier](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers), the method name and its parameter list; it does not include a return type. The following example shows the constructor for a class named `Person`.

```c#
public class Person
{
   private string last;
   private string first;

   public Person(string lastName, string firstName)
   {
      last = lastName;
      first = firstName;
   }

   // Remaining implementation of Person class.
}
```

If a constructor can be implemented as a single statement, you can use an [expression body definition](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members). The following example defines a `Location` class whose constructor has a single string parameter named *name*. The expression body definition assigns the argument to the `locationName` field.

```c#
public class Location
{
   private string locationName;

   public Location(string name) => Name = name;

   public string Name
   {
      get => locationName;
      set => locationName = value;
   }
}
```



#### Class inheritance

When you create a class, you can inherit from any other class that is not defined as [`sealed`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed), and other classes can inherit from your class and override class virtual methods. Furthermore, you can implement one or more interfaces.

Inheritance is accomplished by using a *derivation*, which means a class is declared by using a *base class* from which it inherits data and behavior. A base class is specified by appending a colon and the name of the base class following the derived class name, like this:

```c#
public class Manager : Employee
{
    // Employee fields, properties, methods and events are inherited
    // New Manager fields, properties, methods and events go here...
}
```

When a class declares a base class, it inherits all the members of the base class except the constructors.

A class can be declared [`abstract`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract). An abstract class contains abstract methods that have a signature definition but no implementation. Abstract classes cannot be instantiated. They can only be used through derived classes that implement the abstract methods. By contrast, a [sealed](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed) class does not allow other classes to derive from it. 

#### Example

The following example defines a public class that contains an [auto-implemented property](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties), a method, and a special method called a constructor. For more information, see [Properties](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties), [Methods](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods), and [Constructors](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors) articles. The instances of the class are then instantiated with the `new` keyword.

```c#
using System;

public class Person
{
    // Constructor that takes no arguments:
    public Person()
    {
        Name = "unknown";
    }

    // Constructor that takes one argument:
    public Person(string name)
    {
        Name = name;
    }

    // Auto-implemented readonly property:
    public string Name { get; }

    // Method that overrides the base class (System.Object) implementation.
    public override string ToString()
    {
        return Name;
    }
}
class TestPerson
{
    static void Main()
    {
        // Call the constructor that has no parameters.
        var person1 = new Person();
        Console.WriteLine(person1.Name);

        // Call the constructor that has one parameter.
        var person2 = new Person("Sarah Jones");
        Console.WriteLine(person2.Name);
        // Get the string representation of the person2 instance.
        Console.WriteLine(person2);
    }
}
// Output:
// unknown
// Sarah Jones
// Sarah Jones
```

## Methods

A method is a block of code that contains a series of instructions. A program causes instructions to be executed by calling the method and specifying the necessary method arguments. In C#, all executed statements are performed in the context of a method. The Main method is the entry point for each C# application and is called by the common language runtime (CLR) when the program starts.

```c#
public class SquareExample
{
   public static void Main()
   {
      // Call with an int variable.
      int num = 4;
      int productA = Square(num);

      // Call with an integer literal.
      int productB = Square(12);

      // Call with an expression that evaluates to int.
      int productC = Square(productA * 3);
   }

   static int Square(int i)
   {
      // Store input argument in a local variable.
      int input = i;
      return input * input;
   }
}
```

## namespaces 

Namespaces have the following properties:

- They organize large code projects.
- They're delimited by using the `.` operator.
- The `using` directive obviates the requirement to specify the name of the namespace for every class.
- The `global` namespace is the "root" namespace: `global::System` will always refer to the .NET [System](https://docs.microsoft.com/en-us/dotnet/api/system) namespace.

.NET uses namespaces to organize its many classes, as follows:

```c#
System.Console.WriteLine("Hello World!");
```

[System](https://docs.microsoft.com/en-us/dotnet/api/system) is a namespace and [Console](https://docs.microsoft.com/en-us/dotnet/api/system.console) is a class in that namespace. The `using` keyword can be used so that the complete name isn't required, as in the following example:

```
using System;
Console.WriteLine("Hello World!");
```

Second, declaring your own namespaces can help you control the scope of class and method names in larger programming projects. Use the [namespace](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace) keyword to declare a namespace, as in the following example:

```c#
namespace SampleNamespace
{
    class SampleClass
    {
        public void SampleMethod()
        {
            System.Console.WriteLine(
                "SampleMethod inside SampleNamespace");
        }
    }
}
```

Beginning with C# 10, you can declare a namespace for all types defined in that file, as shown in the following example:

```c#
namespace SampleNamespace;

class AnotherSampleClass
{
    public void AnotherSampleMethod()
    {
        System.Console.WriteLine(
            "SampleMethod inside SampleNamespace");
    }
}
```

### Collections 

For many applications, you want to create and manage groups of related objects. There are two ways to group objects: by creating arrays of objects, and by creating collections of objects

A collection is a class, so you must declare an instance of the class before you can add elements to that collection.

Many common collections are provided by .NET. Each type of collection is designed for a specific purpose.

Some of the common collection classes are described in this section:

- [System.Collections.Generic](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic) classes
- [System.Collections.Concurrent](https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent) classes
- [System.Collections](https://docs.microsoft.com/en-us/dotnet/api/system.collections) classes

You can create a generic collection by using one of the classes in the [System.Collections.Generic](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic) namespace. A generic collection is useful when every item in the collection has the same data type. A generic collection enforces strong typing by allowing only the desired data type to be added.

The following table lists some of the frequently used classes of the [System.Collections.Generic](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic) namespace:

| **Class**               | **Description**                                              |
| ----------------------- | ------------------------------------------------------------ |
| Dictionary<TKey,TValue> | Represents a collection of key/value pairs that are organized based on the key. |
| List<T>                 | Represents a list of objects that can be accessed by index. Provides methods to search, sort, and modify lists. |
| Queue<T>                | Represents a first in, first out (FIFO) collection of objects |
| SortedList<TKey,TValue> | Represents a collection of key/value pairs that are sorted by key based on the associated [IComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1) implementation. |
| Stack<T>                | Represents a last in, first out (LIFO) collection of objects. |

### List<T> Class

Represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists.

```c#
public class List<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.IReadOnlyList<T>, System.Collections.IList
```

#### Type Parameters

The type of elements in the list.

## Methods

| [Add(T)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.add?view=net-6.0#system-collections-generic-list-1-add(-0)) | Adds an object to the end of the [List<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0). |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| [AddRange(IEnumerable<T>)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.addrange?view=net-6.0#system-collections-generic-list-1-addrange(system-collections-generic-ienumerable((-0))) | Adds the elements of the specified collection to the end of the [List](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0). |
| [Remove(T)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.remove?view=net-6.0#system-collections-generic-list-1-remove(-0)) | Removes the first occurrence of a specific object from the [Lis<T>t](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0). |
| [RemoveAll(Predicate<T>)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.removeall?view=net-6.0#system-collections-generic-list-1-removeall(system-predicate((-0)) | Removes all the elements that match the conditions defined by the specified predicate. |



### Interfaces 

An interface contains definitions for a group of related functionalities that a non-abstract [`class`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class) or a [`struct`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct) must implement. An interface may define `static` methods, which must have an implementation. Beginning with C# 8.0, an interface may define a default implementation for members. An interface may not declare instance data such as fields, auto-implemented properties, or property-like events.

By using interfaces, you can, for example, include behavior from multiple sources in a class. That capability is important in C# because the language doesn't support multiple inheritance of classes. In addition, you must use an interface if you want to simulate inheritance for structs, because they can't actually inherit from another struct or class.

You define an interface by using the [`interface`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface) keyword as the following example shows

```c#
interface IEquatable<T>
{
    bool Equals(T obj);
}
```

The name of an interface must be a valid C# [identifier name](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names). By convention, interface names begin with a capital `I`.

#### Interfaces summary

An interface has the following properties:

- In C# versions earlier than 8.0, an interface is like an abstract base class with only abstract members. A class or struct that implements the interface must implement all its members.
- Beginning with C# 8.0, an interface may define default implementations for some or all of its members. A class or struct that implements the interface doesn't have to implement members that have default implementations. For more information, see [default interface methods](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/default-interface-methods-versions).
- An interface can't be instantiated directly. Its members are implemented by any class or struct that implements the interface.
- A class or struct can implement multiple interfaces. A class can inherit a base class and also implement one or more interfaces.

### The Do/While Loop

This loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true.

```csharp
do 
{
  // code block to be executed
}
while (condition);
```

example

```c#
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      do 
      {
        Console.WriteLine(i);
        i++;
      }
      while (i < 5);
    }
  }
}
```

### Lambda Expressions 

Lambda expressions in C# are used like [anonymous functions](https://www.geeksforgeeks.org/anonymous-method-in-c-sharp/), with the difference that in Lambda expressions you don’t need to specify the type of the value that you input thus making it more flexible to use. 
The ‘=>’ is the lambda operator which is used in all lambda expressions. The Lambda expression is divided into two parts, the left side is the input and the right is the expression

**The Lambda Expressions can be of two types:** 

- **Expression Lambda:** Consists of the input and the expression.
  *Syntax:*

  ```c#
  input => expression;
  ```

- **Statement Lambda:** Consists of the input and a set of statements to be executed.
  *Syntax:*

  ```c#
  input => { statements };
  ```

**Example 1:** In the code given below, we have a list of integer numbers. The first lambda expression evaluates every element’s square { x => x*x } and the second is used to find which values are divisible by 3 { x => (x % 3) == 0 }. And the foreach loops are used for displaying.

```c#
// C# program to illustrate the
// Lambda Expression
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expressions {
class Program {
	static void Main(string[] args)
	{
		// List to store numbers
		List<int> numbers = new List<int>() {36, 71, 12,
							15, 29, 18, 27, 17, 9, 34};

		// foreach loop to display the list
		Console.Write("The list : ");
		foreach(var value in numbers)
		{
			Console.Write("{0} ", value);
		}
		Console.WriteLine();

		// Using lambda expression
		// to calculate square of
		// each value in the list
		var square = numbers.Select(x => x * x);

		// foreach loop to display squares
		Console.Write("Squares : ");
		foreach(var value in square)
		{
			Console.Write("{0} ", value);
		}
		Console.WriteLine();

		// Using Lambda expression to
		// find all numbers in the list
		// divisible by 3
		List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);

		// foreach loop to display divBy3
		Console.Write("Numbers Divisible by 3 : ");
		foreach(var value in divBy3)
		{
			Console.Write("{0} ", value);
		}
		Console.WriteLine();
	}
}
}
```

Output

```c#
The list : 36 71 12 15 29 18 27 17 9 34 
Squares : 1296 5041 144 225 841 324 729 289 81 1156 
Numbers Divisible by 3 : 36 12 15 18 27 9 
```

**Example 2:** Lambda expressions can also be used with user-defined classes. The code given below shows how to sort through a list based on an attribute of the class that the list is defined upon.

```c#
// C# program to illustrate the
// Lambda Expression
using System;
using System.Collections.Generic;
using System.Linq;

// User defined class Student
class Student {
	
	// properties rollNo and name
	public int rollNo
	{
		get;
		set;
	}
	
	public string name
	{
		get;
		set;
	}
}

class GFG {
	
	// Main Method
	static void Main(string[] args)
	{
		// List with eah element of type Student
		List<Student> details = new List<Student>() {
			new Student{ rollNo = 1, name = "Liza" },
				new Student{ rollNo = 2, name = "Stewart" },
				new Student{ rollNo = 3, name = "Tina" },
				new Student{ rollNo = 4, name = "Stefani" },
				new Student { rollNo = 5, name = "Trish" }
		};

		// To sort the details list
		// based on name of student
		// in ascending order
		var newDetails = details.OrderBy(x => x.name);

		foreach(var value in newDetails)
		{
			Console.WriteLine(value.rollNo + " " + value.name);
		}
	}
}
```

Output

```
1 Liza
4 Stefani
2 Stewart
3 Tina
5 Trish
```


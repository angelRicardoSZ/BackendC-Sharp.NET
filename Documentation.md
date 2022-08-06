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


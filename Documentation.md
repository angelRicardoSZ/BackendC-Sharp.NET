Documentation

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


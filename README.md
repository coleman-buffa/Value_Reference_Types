# Value and Reference Types

An exploration on the differences between value and reference types in C#. All concepts discussed relate to Value and Reference types. C# manages memory allocation and de-allocation for you.

## The Stack
The stack is a region of memory that is used to store either:
- Value types (int, char, bool, ). The actual value is stored on the stack. For example a 32-bit integer will be allocated 32-bits / 4 bytes on the stack whenever it is declared.
- A memory address, or reference, stored as a either 4 or 8 bytes (32-bit or 64-bit) that points to the location of the actual data stored in the heap. This is why reference types are called so. Memory addresses are typically represented as hexadecimal numbers, though they can be converted to integers if needed.

Items on the stack are stored in a Last In First Out (LIFO) manner. When a function is called, all of its local variables are pushed onto the stack. Once the function is done, all local variables are popped off the stack. Stated otherwise, the stack is aggressive about getting rid of allocated memory which makes it efficient.

When a program starts it is given some default size of memory typically determined by the OS or runtime environment. It is possible to run out of memory in the stack, say during a recursive call, but usually the default stack size is large enough to handle most programs. For reference: the default stack sizes are 1MB and 4MB per thread for 32-bit and 64-bit systems respectively. These values are considered excessive for most programs, and is generally considered a bad practice to mess with those values unless you have a good reason.

The stack size cannot be changed during the execution of a program. The previously stated values are set high to avoid stack overflow errors, but not so large as to waste memory.

## The Heap
Unlike the stack, the heap is a region of memory that can grow and shrink depending on the needs of the executing program. Memory is allocated on the heap whenever an object is created with the `new` word. This memory remains allocated until the object is no longer in use and is released by the garbage collector.

The heap can be as large as you need to store an object. Memory is allocated in the heap as it is needed, but is considered an untidy collection of thing piled up haphazardly. Hence the need for periodic garbage collection.

The name has nothing to do with the data structure that shares the same name.

## Examples from Program.cs

```cs
var numbersArray = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine(numbersArray); // System.Int32[]
```

`ToString()` prints the name of the type of the object because `ToString()` is inherited from the `Object` class.

```cs 
numbersArray[0] = 100;
Console.WriteLine(string.Join(",", numbersArray)); // 100,2,3,4,5
Console.WriteLine(string.Join(",", numbersArray)); // 100,2,3,4,5
```

Changing the values of the first array appears to change it in both arrays because the second array is actually referencing the same object in memory as the first array.
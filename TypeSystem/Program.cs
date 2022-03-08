// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

// better use smallcase int, string etc
int x = 12;
// this one is not recommended
Int32 y = 13;

// strings in C# are immutable
var name = "Hamza";
name = name.ToUpper();
Console.WriteLine(name);

// object is a class, it lives on heap because classes
// live on the heap. This phenomenon is known as Boxing.

// o is pointing on a heap to a box, in which inside there is 23.
// inside the box is value type
object o = 23;
object o1 = 23;

// here the references are compared, not the actual content inside
// the box. So, it will always display Different.
if(o == o1){
    Console.WriteLine("Same");
} else{
    Console.WriteLine("Different");
}

// 2
if(o is 23){
    Console.WriteLine("Same");
}

// 3
if(o.Equals(23)){
    Console.WriteLine("Same");
}

// 4
// unboxing
var n = (int) o;
Console.WriteLine(n);
// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

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

// 5
// static typed language and dynamic typed language
// C# is both statically and dynamically typed language
// dynamic 

int number = 42;
// NOT ALLOWED --> number = "FooBar";

dynamic num = 42;
// ALLOWED
num = "FooBar";

// EdgeJS --> a library that allows us to use C# in JS and vice versa

// 6
// struct or class

void ftn(){
    // struct lives on stack
    // it lives on stack
    var dt = new DateTime();
    var dt1 = dt; // creating a copy

    // classes lives on heap
    // it lives on heap
    var sb = new StringBuilder();
    var sb1 = sb; // creating a reference, not a copy

}

// parallel and multi-threading programming uses struct more

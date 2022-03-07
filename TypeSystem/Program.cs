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
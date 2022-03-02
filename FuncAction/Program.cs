// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;

// 1
var watch = Stopwatch.StartNew();
CountToInfinity(); // Method to Benchmark
watch.Stop();
Console.WriteLine(watch.Elapsed);

// 2
MeasureTime(() => CountToInfinity());


// Action --> delegate void Something()
// it's return type is void, it returns nothing
// 2
static void MeasureTime(Action a){
    var watch = Stopwatch.StartNew();
    a(); // Method to Benchmark
    watch.Stop();
    Console.WriteLine(watch.Elapsed);
}

// 1
static void CountToInfinity(){
    for(var i=0; i<1000; i++);
}

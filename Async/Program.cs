// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Threading;

var lines = File.ReadAllLines("text.txt");

foreach(var line in lines){
    Console.WriteLine(line);
}

Console.WriteLine("*********************************");
// Tasks --> corner stone of async programming in C#
var fileReadTask = File.ReadAllLinesAsync("text.txt");

Console.WriteLine(fileReadTask.Status);
Thread.Sleep(1);
// waiting for 1 ms, the task RanToCompletion from 
// WaitingForActivation
Console.WriteLine(fileReadTask.Status);

// not a good idea
//fileReadTask.Wait();

// 2
File.ReadAllLinesAsync("text.txt").ContinueWith(t =>{
    if(t.IsFaulted){
        Console.Error.WriteLine(t.Exception);
        return;
    }
    // Task will be completed!
    var lines = t.Result;
    foreach(var line in lines){
        Console.WriteLine(line);
    }
});
Console.WriteLine("*********************************");
Console.WriteLine("I am at the end.");

// 3
// async & await keyword solved the above complex programming

async Task ReadLine(){
    var lines = await File.ReadAllLinesAsync("text.txt");
    foreach(var line in lines){
        Console.WriteLine(line);
    }

}

await ReadLine();

Console.WriteLine("*********************************");
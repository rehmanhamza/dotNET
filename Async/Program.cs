// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

var lines = File.ReadAllLines("text.txt");

foreach(var line in lines){
    Console.WriteLine(line);
}
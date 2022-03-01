// See https://aka.ms/new-console-template for more information

// change from debug to release to ship the final software

using MathLibrary;

namespace HelloDotNet{
    class Program{
        static void Main(String[] args){
            Console.WriteLine($"The answer is {MathUtil.Add(2,2)}");

            //Console.WriteLine("Hello");
        }
    }
}
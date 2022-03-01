// See https://aka.ms/new-console-template for more information

using System;

namespace DelegatesandLambdas{
    class Program{
        static void Main(String[] args){
            Console.WriteLine("Hello World!");
            
            // just like a class creating an object
            // the delegate works in same way
            
            // 0
            MathOp f = Add;
            f = Subtract;

            Console.WriteLine(f(1,2));
            
            // 1
            CalculateAndPrint(21, 21, Add);

            // 2 - annonymous function
            CalculateAndPrint(1, 21, delegate(int x, int y) {return x + y;});

            // 3 - lambda function
            CalculateAndPrint(2, 2, (x, y) => x + y);

            // 4
            CalculateAndPrint(2, 27, (x, y) => x * y);

            // 5
            CalculateAndPrint("A", "B", (x,y) => x + y);

            // 6
            CalculateAndPrint(true, true, (x, y) => x && y);
        }

        // Generics
        delegate T Combine<T>(T a, T b);

        delegate int MathOp(int x, int y);

        static void CalculateAndPrint<T>(T x, T y, Combine<T> f){
            var result = f(x, y);
            Console.WriteLine($"result = {result}");
        }

        static int Add(int x, int y){
            return x + y;
        }

        static int Subtract(int x, int y){
            return x - y;
        }
    }
}
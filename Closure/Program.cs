// See https://aka.ms/new-console-template for more information

// 2
// Factoring pattern
Func<int, int> cal = CreateCalculator();
Console.WriteLine(cal(4));

// 1
int CalculateSomething(int n){
    if(n == 0) 
        return 0;

    var factor = 4;
    return factor * CalculateSomething(n - 1);
}

// 2
// returns a delegate
Func<int, int > CreateCalculator(){
    var factor = 4;
    return n => n * factor;
}

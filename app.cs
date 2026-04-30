// version 1.0.0
using System;  

class App
{
    Console.WriteLine("Калькулятор v2.0-GITHUB");
    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static void Main()
    {
        int result = Subtract(30, 12);
        Console.WriteLine("Разность: " + result);
    }
}

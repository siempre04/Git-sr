using System;  

class App
{
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
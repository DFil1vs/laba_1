using System;
using ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        geometricpr gp = new geometricpr(2, 3);

        Console.WriteLine("Первая геометрическая прогрессия:");
        Console.WriteLine(gp);

        Console.WriteLine($"a0 = {gp.Elementj(0)}");
        Console.WriteLine($"a1 = {gp.Elementj(1)}");
        Console.WriteLine($"a2 = {gp.Elementj(2)}"); 
        Console.WriteLine($"a5 = {gp.Elementj(5)}"); 
    }
}






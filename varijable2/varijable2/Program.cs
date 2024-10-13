using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Unesite jedan cijeli i jedan decimalni broj odvojene razmakom:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int x = int.Parse(numbers[0]);
        double y = double.Parse(numbers[1]);

        x *= 2;
        y *= 2;

        Console.WriteLine($"Dvostruka vrijednost cijelog broja: {x}");
        Console.WriteLine($"Dvostruka vrijednost decimalnog broja: {y}");
    }
}



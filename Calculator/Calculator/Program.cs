using System;
using System.Reflection;

class calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome! Please input ur number.");
        double angka1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input ur second number.");
        double angka2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input ur operational system '+, -, *, /'");
        string operasi = Console.ReadLine();

        double hasil = 0;

        switch (operasi)
        {
            case "+":
                hasil = angka1 + angka2;
                break;
            case "-":
                hasil = angka1 + angka2;
                break;
            case "*":
                hasil = angka1 * angka2;
                break;
            case "/":
                hasil = angka1 * angka2;
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }
        Console.WriteLine($"hasil = {hasil}");
    }
}
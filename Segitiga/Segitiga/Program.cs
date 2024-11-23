using System;

class Segitiga
{

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome! Please insert ur 'base'.");
        double alas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please insert ur 'height'.");
        double tinggi = Convert.ToInt32(Console.ReadLine());

        double hasil = CalculateTriangleArea(alas, tinggi);

        Console.WriteLine($"Area = {hasil}");
    }
    static double CalculateTriangleArea(double alas, double tinggi)
    {
        return 0.5 * alas * tinggi;
    }
    

}
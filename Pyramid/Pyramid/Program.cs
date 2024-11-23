using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows for the pyramid: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
               
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }

               for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
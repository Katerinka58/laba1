using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            for (int i = 0; i < n; i++)
            {
                int factorialN = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorialN *= j;
                }

                result += ((Math.Pow(-1, i) * Math.Pow(x, i)) / factorialN);
            }
            Console.WriteLine(result);
        }
    }
}

using System;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника №1: ");
            int height1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < height1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                    Console.WriteLine();
            }

            Console.WriteLine("Введите высоту треугольника №2: ");
            int height2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < height2; i++)
            {
                for (int j = height2; j > i; j--)
                {
                    Console.Write("*");
                }
                    Console.WriteLine();
            }

            Console.WriteLine("Введите высоту треугольника №3: ");
            int height3 = int.Parse(Console.ReadLine());
            for (int i = 0; i < height3; i++)
            {

                for (int j = height3; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int w = 0; w <= i; w++)
                {
                    Console.Write("*");
                }
                    Console.WriteLine();
            }

            Console.WriteLine("Введите высоту треугольника №4: ");
            int height4 = int.Parse(Console.ReadLine());
            for (int i = 0; i < height4; i++)
            {

                for (int j = i; j < height4; j++)
                {
                     Console.Write("*");
                }
                     Console.WriteLine();
                for (int w = 0; w <= i ; w++)
                {
                     Console.Write(" ");
                }
            }
        }
    }
}

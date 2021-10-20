using System;
namespace Лаб_работа_1
{
    class Program

    {
        static void Main(string[] args)

        {

            try

            {
                double x, b, a, T, y;
                Console.WriteLine("введите x:");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("введите b:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("введите a:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("введите y:");
                y = double.Parse(Console.ReadLine());
                T = Math.Sqrt(x + a - b) + Math.Log(y) / Math.Atan(b + a);
                Console.WriteLine(string.Format("T = {0:F2}", T));
            }
            catch (Exception e)
            {
                Console.WriteLine("введите корректное значение");
            }

        }

    }

}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи число 1");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введи число 2");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
            Console.WriteLine("Введи 1 число");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введи 2 число");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введи 3 число");
            double z = Convert.ToDouble(Console.ReadLine());
            if (x < (y + z) & (y < (x + z)) & (z < (x + y)))
            {
                Console.WriteLine("треугольника нету");
            }
            else
            {
                Console.WriteLine("треугольника es");
            }
            Console.ReadKey();

        }
    }
}

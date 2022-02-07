using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int nuber = int.Parse(Console.ReadLine());

            if((nuber & 1) == 0)
            {
                Console.WriteLine($"Число {nuber} четное");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Число {nuber} нечетное");
                Console.ReadKey();
            }
        }
    }
}

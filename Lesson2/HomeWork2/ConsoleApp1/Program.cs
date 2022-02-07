using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите минимальную температуру за дань");
            int mintemp = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите максимальную температуру за день");
            int maxtemp = int.Parse(Console.ReadLine());
            int avgtemp = (mintemp + maxtemp) / 2;
            Console.WriteLine($"Средняя температура за день {avgtemp}");
            Console.ReadLine();



        }
    }
}

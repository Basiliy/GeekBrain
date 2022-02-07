using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер текущего месяца");
            int nummonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите минимальную температуру за дань");
            int mintemp = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите максимальную температуру за день");
            int maxtemp = int.Parse(Console.ReadLine());
            int avgtemp = (mintemp + maxtemp) / 2;
            string month = null;

            switch (nummonth)
            {
                case 1:
                    month = "январь";
                    break;
                case 2:
                    month = "февраль";
                    break;
                case 3:
                    month = "март";
                    break;
                case 4:
                    month = "апрель";
                    break;
                case 5:
                    month = "май";
                    break;
                case 6:
                    month = "июнь";
                    break;
                case 7:
                    month = "июль";
                    break;
                case 8:
                    month = "август";
                    break;
                case 9:
                    month = "сентябрь";
                    break;
                case 10:
                    month = "октябрь";
                    break;
                case 11:
                    month = "ноябрь";
                    break;
                case 12:
                    month = "декабрь";
                    break;

            }

            if (avgtemp > 0 && (nummonth == 12 || nummonth == 1 || nummonth == 2))
            {
                Console.WriteLine($"За окном {month} месяц. Дождливая зима. В Средняя температара за день {avgtemp} градусов");
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine($"За окном {month} месяц. Средняя температура за день {avgtemp} градусов");
                Console.ReadKey();
            };
        }
    }
}

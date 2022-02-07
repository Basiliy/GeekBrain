using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
    
            [Flags]
            public enum Weekdays
            {
                Monday = 0b_0000001,
                Tuesday = 0b_0000010,
                Wednesday = 0b_0000100,
                Thursday = 0b_0001000,
                Friday = 0b_0010000,
                Saturday = 0b_0100000,
                Sunday = 0b_1000000,
            }

            static void Main(string[] args)
            {


                // Расписание офисов
                Weekdays workingDaysOffice1 = Weekdays.Monday | Weekdays.Tuesday | Weekdays.Wednesday | Weekdays.Tuesday | Weekdays.Friday | Weekdays.Saturday | Weekdays.Sunday; ;
                Weekdays workingDaysOffice2 = Weekdays.Monday | Weekdays.Tuesday;
                Weekdays workingDaysOffice3 = Weekdays.Saturday | Weekdays.Sunday;

            Console.WriteLine("Show schedule of all offices? (Yes\\No)");
            string scheduleAll = Console.ReadLine();
            if (scheduleAll == "Yes")
            {
                Console.WriteLine($"Working days for office 1 are: {workingDaysOffice1}.");
                Console.WriteLine($"Working days for office 2 are: {workingDaysOffice2}.");
                Console.WriteLine($"Working days for office 3 are: {workingDaysOffice3}.");
                Console.ReadKey();

            }
            else
            {
                Console.Write("Enter an office number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
                switch (number)
                {
                    case 1:
                        Console.WriteLine($"Working days for office {number} are: {workingDaysOffice1}.");
                        Console.ReadKey();
                        
                        break;
                    case 2:
                        Console.WriteLine($"Working days for office {number} are: {workingDaysOffice2}.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine($"Working days for office {number} are: {workingDaysOffice3}.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Enter a correct office number!");
                        Console.ReadKey();
                        break;

                }
            }




        }
        }
}

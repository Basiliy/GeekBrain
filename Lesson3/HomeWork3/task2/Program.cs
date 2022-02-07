using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[,] phonebook = new string[5, 2];
            phonebook[0, 0] = "Иванов";
            phonebook[0, 1] = "89037773211";
            phonebook[1, 0] = "Петров";
            phonebook[1, 1] = "89039993211";
            phonebook[2, 0] = "Сидоров";
            phonebook[2, 1] = "89031113211";
            phonebook[3, 0] = "Филиппова";
            phonebook[3, 1] = "89034473777";
            phonebook[4, 0] = "Свиридова";
            phonebook[4, 1] = "89034473999";

            for (int i = 0; i < phonebook.GetLength(0); i++)
            {
                for (int j = 0; j < phonebook.GetLength(1); j++)
                {
                    System.Console.Write($"{phonebook[i, j]} ");
                }
                System.Console.WriteLine();
            }


            Console.ReadKey();

        }
    }
}

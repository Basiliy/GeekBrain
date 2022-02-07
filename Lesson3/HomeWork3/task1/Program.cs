using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };

            int rows = matrix.GetUpperBound(0) + 1;    // количество строк
            int columns = matrix.Length / rows;        // количество столбцов
                                                       // или так
                                                       // int columns = numbers.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
            
                    
                        for (int j = 0; j < columns; j++)
                        {
                    if (j != i) { Console.Write($" \t"); }
                    else
                    {
                        Console.Write($"{matrix[i, j]} \t");
                    }
                        }
                    
                Console.WriteLine();

            }
            Console.ReadKey();



        }
    }
}

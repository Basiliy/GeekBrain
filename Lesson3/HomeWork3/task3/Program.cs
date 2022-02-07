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
            Console.WriteLine("Введите текст");
            string text = "";
            text = Console.ReadLine();
            char[] sReverse = text.ToCharArray();
            Array.Reverse(sReverse);
            text = new string(sReverse);
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0000123;
            DateTime date = DateTime.Now;
            string nameOrg = "ООО Ширли Мырли";
            string INN = "890312344577";
            string adress = "г.Самара, ул.Победы 131";
            string CHO = "ОСН";
            int shift = 58;
            string cashier = "Иванов Иван Иванович";
            string operation = "Приход";
            string item1 = "Ноутбук apple MacBook pro 15 2018, core i9, ОЗУ 16гб,HDD 512Гб";
            int quantity1 = 1;
            int priceItem1 = 215000;
            int payItem1 = priceItem1 * quantity1;
            string item2 = "USB Type-C 32Гб";
            int quantity2 = 3;
            int priceItem2 = 875;
            int payItem2 = priceItem2 * quantity2;
            int NDS = 20;
            int sum = payItem1 + payItem2;
            int sumNds = sum / 100 * NDS;
            string currency = "руб.";
            int cash = 220000;
            int change = cash - sum;
            double numberKKT = 4859356389;
            long idKKT = 4348885999422284;
            long idFN = 757574778883354;
            string wwwFNS = "www.nalog.ru";

            Console.WriteLine($" __________________________________________");
            Console.WriteLine($"             {nameOrg}                     ");
            Console.WriteLine($"       {adress}                        ");
            Console.WriteLine($" ИНН: {INN}                 СНО: {CHO} ");
            Console.WriteLine($" Смена №: {shift}                    {date.ToShortDateString()} ");
            Console.WriteLine($" Кассир: {cashier}                        ");
            Console.WriteLine($" ------------------------------------------");
            Console.WriteLine($" ------------------------------------------");
            Console.WriteLine($"           Кассовый чек / {operation}           ");
            Console.WriteLine(Regex.Replace($" {item1} {quantity1}шт*{priceItem1}......{payItem1}{currency}", "(?<=\\G.{45})(?=.)", "\n"));
            Console.WriteLine(Regex.Replace($" {item2} {quantity2}шт*{priceItem2}.............{payItem2}{currency}", "(?<=\\G.{45})(?=.)", "\n"));
            Console.WriteLine($" ------------------------------------------");
            Console.WriteLine($" ------------------------------------------");
            Console.WriteLine($" НДС: {NDS}%");
            Console.WriteLine($" ИТОГ:........................... {sum} {currency}");
            Console.WriteLine($" Сумма НДС:........................{sumNds} {currency}");
            Console.WriteLine($" Наличными:.......................{cash} {currency}");
            Console.WriteLine($" Сдача:.............................{change} {currency}");
            Console.WriteLine($"-------------------------------------------");
            Console.WriteLine($"-------------------------------------------");
           // Console.WriteLine($"  Чек №:..............................{number}");
            Console.WriteLine($"     _________________________________");
            Console.WriteLine($"    |                                 |"); 
            Console.WriteLine($"    | Дата: {date}       |");
            Console.WriteLine($"    | Чек № {number}                       |");
            Console.WriteLine($"    | РН ККТ: {idKKT}        |");
            Console.WriteLine($"    | ЗН ККТ: {numberKKT}              |");
            Console.WriteLine($"    | ФН: {idFN}             |");
            Console.WriteLine($"    | Сайт ФНС: {wwwFNS}          |");
            Console.WriteLine($"    |_________________________________|");
            Console.WriteLine("");
            Console.WriteLine("            СПАСИБО ЗА ПОКУПКУ!    ");
            Console.WriteLine($"     _________________________________");
            Console.WriteLine($" __________________________________________");
            Console.ReadKey();
        }
    }
}

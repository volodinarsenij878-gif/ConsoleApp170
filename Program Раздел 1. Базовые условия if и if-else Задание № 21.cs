using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program21
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine(n == 0 ? "Равно нулю" : "Не равно нулю");
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}
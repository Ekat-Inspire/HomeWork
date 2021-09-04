using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Укажите минимальную температуру за сутки:");
            var min = Console.ReadLine();
            int a = Convert.ToInt32(min);

            Console.WriteLine("Укажите максимальную температуру за сутки:");
            var max = Console.ReadLine();
            int b = Convert.ToInt32(max);

            var x = (a + b) / 2;

            Console.WriteLine($"Среднесуточная температура: {x}");


        }







    }
}
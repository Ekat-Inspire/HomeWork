using System;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            var a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            if (b % 2 == 1)
            {
                Console.WriteLine("Число нечетное");
            }
            else
            {
                Console.WriteLine("Число четное");
            }
        }
    }
}

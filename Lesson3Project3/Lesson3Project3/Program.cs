using System;

namespace Lesson3Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите тект:");

            string a = Console.ReadLine();
            
                for (int i = a.Length - 1; i >= 0; i--)
                    Console.Write(a[i]);
                            



            

        }
    }
}

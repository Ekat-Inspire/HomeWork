using System;

namespace Lesson1Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя пользователя:");
            var name = Console.ReadLine();

            Console.WriteLine($"Привет {name}, сегодня {DateTime.Now}"); 
    }
}

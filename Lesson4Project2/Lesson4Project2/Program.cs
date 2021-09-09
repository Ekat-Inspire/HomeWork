using System;

namespace Lesson4Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите набор чисел, разделенных пробелом:");
            string a  = Console.ReadLine();
            int x = Convert.ToInt32(a);
        
            int sum = x.Sum();
            Console.WriteLine("Сумма элементов: " + sum);

            // Решение задачи не получилось: 1) не могу понять, как строку введеную, перевестив масств int []

          }
    }
}

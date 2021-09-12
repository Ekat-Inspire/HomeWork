using System;
using System.IO;
using System.Text; 


namespace Lesson5Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";
           
            File.WriteAllLines(filename, new[] { DateTime.Now.ToString(), "Перед началом этого текста, Вы должны увидеть текущую дату и время :) " });

            string fileText = File.ReadAllText(filename);
            Console.WriteLine(fileText);
        }
    }
}

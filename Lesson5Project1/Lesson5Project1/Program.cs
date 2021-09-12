using System;
using System.IO;
using System.Text;

namespace Lesson5Project1
{
    class Test
    {
        public static void Main(string[] args)
        { 
            string filename = "text.txt";
            Console.WriteLine("Введете текст:");
            File.WriteAllText(filename, Console.ReadLine());
            string fileText = File.ReadAllText(filename);
            Console.WriteLine(fileText); //Вывела на экран, то что записалась
            
            
            




        }
        

    }
}

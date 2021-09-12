using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text;
using System;


namespace Lesson5Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный набор числе (0..255)"); // и записать их в бинарный файл

            var my = Console.ReadLine();
                        
            
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("my.bin", FileMode.OpenOrCreate), my);


        }
    }
}

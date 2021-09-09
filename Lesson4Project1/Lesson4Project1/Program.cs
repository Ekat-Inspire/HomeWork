using System;

namespace Lesson4Project1
{
    class Program
    {
        static void Main(string[] args)
          
        {
            
            Console.WriteLine(GetFullName("Иванов", "Иван", "Иванович"));
            Console.WriteLine(GetFullName("Степанов", "Степан", "Александрович"));
            Console.WriteLine(GetFullName( "Екатерина", "Зазуля","Алексеевна"));
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $" {firstName} {lastName} {patronymic}";
        }
    }
    
}

using System;

namespace Lesson3Project2
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("Телефонный справочник");
            
            string[,] array = new string[,]
            {
           {"Иванов","Петров", "Сидоров", "Петрова", "Соколова"},
            {"123-123/ivanov@mail.ru","456-456/petrov@mail.ru","789-789/sidorov@mail.ru","987-985/petrova@mail.ru","654-123/sokolova@mail.ru"}
            };

                 for (int i = 0; i < array.GetLength(0); i++)
                  {

                 for (int j = 0; j < array.GetLength(1); j++)
                  {
                    
                    Console.WriteLine(array[i, j]); // не получилось сделать фамилию и контакт рядом - не смогла найти решение, чтобы они были друг на против друга :((
                                   

                }



            }

        }
    }
}

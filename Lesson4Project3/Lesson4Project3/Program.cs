using System;

namespace Lesson4Project3
{
    class Program
    { }
    enum season { Summer, Autumn, Spring, Winter }
    static season Month(int xy)                    // не понимаю как сделать возврат к Month
    {
        Console.WriteLine("Введите номер месяца: ");
        string m = Console.ReadLine();
        int x = Convert.ToInt32(m);
        if (12 < x || x <= 0)

            Console.WriteLine("Ошибка: введите число от 1 до 12");

        switch (x)
        {
            case 1:
                return season.Winter;
            case 2:
                return season.Winter;
            case 3:
                return season.Spring;
            case 4:
                return season.Spring;
            case 5:
                return season.Spring;
            case 6:
                return season.Summer;
            case 7:
                return season.Summer;
            case 8:
                return season.Summer;
            case 9:
                return season.Autumn;
            case 10:
                return season.Autumn;
            case 11:
                return season.Autumn;
            case 12:
                return season.Winter;
        }
        static string seasonRUS(season z)
        {
            switch (z)
            {
                case season.Winter:
                    return "Зима";
                case season.Spring:
                    return "Весна";
                case season.Summer:
                    return "Лето";
                case season.Autumn:
                    return "Осень";

            }
            {

                return Console.ReadLine(); 
    }                                        
        }
          
    }
}

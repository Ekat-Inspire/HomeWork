using System;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kassir = "Иванов Иван Иванович, Продавец-кассир";
            Console.WriteLine("Н.МАША Б/пр. к/м М-Б. зел.яб.200г");
            Console.WriteLine("Введите цену товара:");
            var a1 = Console.ReadLine();
            float b1 = Convert.ToSingle(a1);

            Console.WriteLine("Введите количество товара:");
            var price1 = Console.ReadLine();
            float x1 = Convert.ToSingle(price1);
            float y1 = b1 * x1;
            

            Console.WriteLine("АГУША Пюре фрукт.ябл-мал-шип90г");
            Console.WriteLine("Введите цену товара:");
            var a2 = Console.ReadLine();
            float b2 = Convert.ToSingle(a2);

            Console.WriteLine("Введите количество товара:");
            var price2 = Console.ReadLine();
            float x2 = Convert.ToSingle(price2);
            float y2 = b2 * x2;

            double y = y1 + y2;
            y = Math.Round(y, 2); // почему не считает с типом данных Float?

            double NDS = y * 10 / 110;
            NDS = Math.Round(y, 2);


            Console.WriteLine("                  ПЯТЁРОЧКА");
            Console.WriteLine("                 Кассовый чек");
            Console.WriteLine("Цена до скидки | Скидка | Цена | Кол-во | Итого");
            Console.WriteLine("Н.МАША Б/пр. к/м М-Б. зел.яб.200г");
            Console.WriteLine($"НДС 10%   {b1}              {b1}*{x1}              {y1}");
            Console.WriteLine("АГУША Пюре фрукт.ябл-мал-шип90г");
            Console.WriteLine($"НДС 10%   {b2}              {b2}*{x2}              {y2}");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"СКИДКА:  0.00      ПОДЫТОГ: {y}");
            Console.WriteLine($"ОКРУГЛЕНИЕ:  0.00      ИТОГО: {y}");
            Console.WriteLine($"НАЛИЧНЫМИ  0.00      ПРИНЯТО: 0.00");
            Console.WriteLine($"БЕЗНАЛИЧНЫМИ  {y}      СДАЧА: 0.00");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"Сумма НДС 20%  0.00      Сумма НДС 10%: {NDS}");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("ООО Агроторг");
            Console.WriteLine("ИНН 7825706086 СНО:ОСН       Код: 382Е");
            Console.WriteLine("620075, 66, Свердловская область г. Екатеринбург, ул. Луначарского , 87");
            Console.WriteLine($"Кассир: {Kassir}");
            Console.WriteLine($"{DateTime.Now}");
            Console.WriteLine("Кассa3: Смена: 344 Чек: 193 ПРИХОД"); ;
            Console.WriteLine("Место расчетов: 382Е: 18394 - Пятерочка");


        }
    }
}

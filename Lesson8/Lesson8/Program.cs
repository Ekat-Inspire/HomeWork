using System;
using System;
using System.Configuration;
using System.Runtime.CompilerServices;
using static System.Console;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)

        /*
         * Создать консольное приложение, которое при старте выводит приветствие, 
         * записанное в настройках приложения (application-scope). 
         * Запросить у пользователя имя, возраст и род деятельности, 
         * а затем сохранить данные в настройках. 
         * При следующем запуске отобразить эти сведения. 
         * Задать приложению версию и описание.
              
        */
            
          {
            Console.WriteLine(Resources.UserInfo);

            var configuration = ConfigurationManager.OpenMappedExeConfiguration(
                new() { ExeConfigFilename = "App.config" },
                ConfigurationUserLevel.None);

    var userInfo = configuration.GetSection(nameof(UserInfo)) as UserInfo;
    var welcome = string.IsNullOrEmpty(userInfo?.Name)
        ? configuration.AppSettings.Settings["Приветствую Вас в нашем консольном приложение"].Value
        : $"Приветствую Вас в нашем консольном приложение {userInfo}";

    Console.WriteLine(welcome);

            Console.WriteLine("Введите имя пользователя:");
    var name = Console.ReadLine();
            Console.WriteLine("Введите возраст пользователя:");
    var age = Console.ReadLine().AsSpan();
            if (!int.TryParse(age, out var ageNumber))
            {
                Console.WriteLine("Неверно");
                return;
            }
            Console.WriteLine("Введите род деятельности:");
var career = Console.ReadLine();


userInfo.Name = name;
userInfo.Age = ageNumber;
userInfo.Career = career;

config.Save(ConfigurationSaveMode.Minimal);



        }
    }
}
   


    






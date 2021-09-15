using System;
using System.Diagnostics;



namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine("ID: {0} Name: {1}", process.Id, process.ProcessName); // вывела все id и имя процесса

                            }
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine("Введите имя или ID процесса, который хотите закрыть:");
                string id = Console.ReadLine();
                Process proces = Process.GetProcessById(Int32.Parse(id));

                
                if (process  != null)
                    process.Kill();
                else
                    throw new Exception();
            }
                    }
    }
    
    }


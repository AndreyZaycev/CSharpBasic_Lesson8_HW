using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_HomeWork
{
    internal class Program
    {
        //вывод приветствия на старте 
        static void SayHello()
        {
            //переменная sHello определена в настройках
            Console.WriteLine(Properties.Settings.Default.sHello);
        }

        //запрос и запись переменной в настройки
        //переменная: имя пользователя 
        private static void SetAndSaveUserName()
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default._userName))
            {
                Console.Write("Введите имя пользователя : ");
                Properties.Settings.Default._userName = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
        }

        //запрос и запись переменной в настройки
        //переменная: возраст пользователя 
        private static void SetAndSaveUserAge()
        {
            if (Properties.Settings.Default._userAge == 0)
            {
                Console.Write("Введите возраст пользователя : ");
                Properties.Settings.Default._userAge = Convert.ToInt32(Console.ReadLine());
                Properties.Settings.Default.Save();
            }
        }

        //запрос и запись переменной в настройки
        //переменная: род деятельности пользователя 
        private static void SetAndSaveUserActivity()
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default._userActivity))
            {
                Console.Write("Введите род деятельности пользователя : ");
                Properties.Settings.Default._userActivity = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
        }

        //вывод информации о пользлвателе
        private static void PrintUserInformation()
        {
            Console.WriteLine($"Имя пользователя : {Properties.Settings.Default._userName}");
            Console.WriteLine($"Возраст пользователя : {Properties.Settings.Default._userAge}");
            Console.WriteLine($"Род деятельности пользователя : {Properties.Settings.Default._userActivity}");
        }

        static void Main(string[] args)
        {
            //
            Console.WriteLine("Урок 8, домашнее задание");
            Console.WriteLine();

            //
            SayHello();

            //
            SetAndSaveUserName();
            SetAndSaveUserAge();
            SetAndSaveUserActivity();

            //
            PrintUserInformation();

            //
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            string namePlayer = "";
            int agePlayer = 0;
            string mailPlayer = "";
            string passwordPlayer = "";

            while (userInput != "Esc")
            {
                Console.WriteLine("Выберите команду:");
                Console.WriteLine("SetName - Установить ник");
                Console.WriteLine("SetAge - Установить ваш возраст");
                Console.WriteLine("SetMail - Установить адрес эл. почты");
                Console.WriteLine("SetPass - Установить пароль");
                Console.WriteLine("Profile - Ваш профиль");
                Console.WriteLine("Esc - Выход из программы");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "SetName":
                        {
                            Console.WriteLine("Введите ваше имя:");
                            namePlayer = Console.ReadLine();
                            break;
                        }
                    case "SetAge":
                        {
                            Console.WriteLine("Укажите ваш возраст:");
                            agePlayer = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                    case "SetMail":
                        {
                            Console.WriteLine("Введите адрес вашей эл. почты:");
                            mailPlayer = Console.ReadLine();
                            break;
                        }
                    case "SetPass":
                        {
                            Console.WriteLine("Установите пароль");
                            passwordPlayer = Console.ReadLine();
                            break;
                        }
                    case "Profile":
                        {
                            Console.WriteLine($"Ваш ник: {namePlayer}\n" +
                                $"Ваш возраст {agePlayer}\n" +
                                $"эл. почта {mailPlayer}");
                            break;
                        }
                    case "Esc":
                        {
                            Console.WriteLine("До свидания!");
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}

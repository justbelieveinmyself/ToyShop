using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    partial class Program
    {
        static Command ReadCommand()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if(Enum.TryParse(input, true, out Command command)){
                    return command;
                }
                else
                {
                    Console.WriteLine("Неизвестная команда. Введите help для подсказки");
                }
            }
        }
        static void WriteHelpMessage()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("Справка - help");
            Console.WriteLine($"{Command.AddToy} - Добавить новую игрушку;");
            Console.WriteLine($"{Command.GetAllToys} - Вывести полный список доступных игрушек;");
            Console.WriteLine($"{Command.SellToy} - Продать игрушку;");
            Console.WriteLine($"{Command.Exit} - Выход из приложения;");
            Console.WriteLine($"{Command.Help} - Помощь;");
        }
    }
}

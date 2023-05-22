using Interfaces;
using MainClasses;
using Data.Memory;
using Settings;
namespace ToyShop
{
    partial class Program
    {

        private static Configuration _configuration;
        private static IToy CreateToy(string name, string manufacturer, int price)
        {
            var toy = _configuration.Container.GetInstance<IToy>();
            toy.Name = name;
            toy.Manufacturer = manufacturer;
            toy.Price = price;
            var shop = _configuration.Container.GetInstance<IShop>();
            shop.Add(toy);
            return toy;
        }
        private static ICheck CreateCheck(IToy toy)
        {
            var shop = _configuration.Container.GetInstance<IShop>();
            var check = shop.Sell(toy);
            return check;
        }
        private static void ShowAllToys()
        {
            Console.WriteLine("Список всех доступных игрушек:");
            var shop = _configuration.Container.GetInstance<IShop>();
            var books = shop.GetAllToys();
            foreach(var book in books)
            {
                Console.WriteLine(book);
            }
        }
        private static void SellToy()
        {
            Console.WriteLine("Создание продажи игрушки.");
            IToy toy;
            while (true)
            {
                Console.Write("Введите название: ");
                var name = Console.ReadLine();
                var shop = _configuration.Container.GetInstance<IShop>();
                var toys = shop.GetAllToys();
                var result = toys.FirstOrDefault(toy => toy.Name == name);
                if(result != null)
                {
                    toy = result;
                    break;
                }
                Console.WriteLine("Не удалось найти книгу с таким именем.");
            }
            var check = CreateCheck(toy);
            Console.WriteLine($"Новая продажа игрушки в магазине {check.Shop.Name} по адресу {check.Shop.Adress}");
            Console.WriteLine($"{check.DateTime}");
            Console.WriteLine("Наименование: " + check.Toy.Name);
            Console.WriteLine("Цена: " + check.Toy.Price);
        }
        private static IShop CreateShop(string name, string adress)
        {
            var shop = _configuration.Container.GetInstance<IShop>();
            shop.Name = name;
            shop.Adress = adress;
            return shop;
        }
        static void Main(string[] args)
        {

            try
            {
                _configuration = new Configuration();
                //_configuration.Container.
                var shop = CreateShop("Devil's dreams", "ул. Залесская");
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine($"Добрый день. Добро пожаловать в панель управления магазином {shop.Name}.");
                Console.WriteLine("Пожалуйста, введите нужную команду или help для помощи.");
                while (true)
                {
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                    switch (ReadCommand())
                    {
                        case Command.AddToy:
                            AddToy();
                            break;
                        case Command.GetAllToys:
                            ShowAllToys();
                            break;
                        case Command.SellToy:
                            SellToy();
                            break;
                        case Command.Exit:
                            Environment.Exit(0);
                            break;
                        case Command.Help:
                            WriteHelpMessage();
                            break;
                        default:
                            Console.WriteLine("Ошибка ввода команды. Свяжитесь с разработчиком или напишите help для помощи.");
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Неизвестная ошибка:" + ex.Message);
            }
        }
        static void AddToy()
        {
            Console.WriteLine("Добавление новой игрушки");
            Console.Write("Введите название: ");
            var name = Console.ReadLine();
            Console.Write("Введите производителя: ");
            var manufacturer = Console.ReadLine();
            Console.Write("Введите цену: ");
            var acces = int.TryParse(Console.ReadLine(), out var price);
            if(!acces)
            {
                Console.WriteLine("Неверно указана цена.");
                return;
            }
            var toy = CreateToy(name, manufacturer, price);
            Console.WriteLine($"Добавлена {toy.ToString()}");
        }
    }
}
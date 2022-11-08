using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            ParamsMenu.WinY = Console.WindowHeight/2;
            ParamsMenu.WinX = Console.WindowWidth / 2;
            List<Warehouse> warehouse = new()
            {
                new Warehouse() { title = -1, name = "Конец заказа" },
                new Warehouse() { title = -1, name = "Декор" },
                new Warehouse() { title = -1, name = "Глазурь" },
                new Warehouse() { title = -1, name = "Количество" },
                new Warehouse() { title = -1, name = "Вкус" },
                new Warehouse() { title = -1, name = "Размер" },
                new Warehouse() { title = -1, name = "Форма" },
                new Warehouse() { title = 6, name = "Квадрат", price = 500 },
                new Warehouse() { title = 6, name = "Круг", price = 500 },
                new Warehouse() { title = 6, name = "Сердце", price = 700 },
                new Warehouse() { title = 1, name = "Звёздочки", price = 200 },
                new Warehouse() { title = 1, name = "Палочки", price = 300 },
                new Warehouse() { title = 1, name = "Трубочки", price = 250 },
                new Warehouse() { title = 2, name = "Шоколадная", price = 200 },
                new Warehouse() { title = 2, name = "Белый шоколад", price = 300 },
                new Warehouse() { title = 2, name = "Кофейная", price = 700 },
                new Warehouse() { title = 3, name = "1", price = 500 },
                new Warehouse() { title = 3, name = "2", price = 1000 },
                new Warehouse() { title = 3, name = "3", price = 1500 },
                new Warehouse() { title = 4, name = "Клубничный", price = 100 },
                new Warehouse() { title = 4, name = "Банановый", price = 200 },
                new Warehouse() { title = 4, name = "Шоколадный", price = 300 },
                new Warehouse() { title = 5, name = "Маленький", price = 200 },
                new Warehouse() { title = 5, name = "Среднй", price = 300 },
                new Warehouse() { title = 5, name = "Большой", price = 500 },
            };
            InUI.UI(warehouse);
        }
    }
}
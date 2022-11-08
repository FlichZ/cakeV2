using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace cake
{
    internal class InUI
    {
        public static int UI(List<Warehouse> warehouse)
        {
            int Select = 0;
            int CrutchPrice = 0;
            List<TotalList> Contentcheque = new();
            string CrutchName = null;
            int CrutchTitle = 0;
            int TotalPrice = 0;
            string TotalChek = null;
            while (true)
            {
                var MenuSelect =
                   from Menu in warehouse
                   where Menu.title == Content.ReturnMenu
                   select Menu;
                int Counter = 0;
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                if (Content.ReturnMenu == -1)
                {
                    var Total =
                       from identically in Contentcheque
                       select identically;
                    TotalPrice = 0;
                    TotalChek = null;
                    foreach (TotalList item in Total)
                    {
                        TotalChek += item.totalName + " - " + item.price + " ";
                        TotalPrice += item.price;
                    }
                }
                Console.WriteLine("Конечная цена: " + TotalPrice);
                Console.WriteLine("Конечный чек: " + TotalChek);

                foreach (Warehouse bools in MenuSelect)
                {
                    Console.SetCursorPosition(ParamsMenu.WinX - bools.name.Length / 2, ParamsMenu.WinY - Counter);
                    if (Select == Counter)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(bools.name);
                        if (bools.price > 0) 
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(" - " + bools.price); 
                            CrutchPrice = bools.price;
                            CrutchName = bools.name;
                            CrutchTitle = bools.title;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(bools.name);
                        if (bools.price > 0) Console.Write(" - " + bools.price);
                    }
                    Counter++;
                }

                Console.SetCursorPosition(ParamsMenu.WinX, ParamsMenu.WinY + Counter);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                string inputKey = Console.ReadKey().Key.ToString();

                if (inputKey == "DownArrow" && Select > 0)
                {
                    Select -= 1;
                }
                else if (inputKey == "Enter" && Select == 0 && Content.ReturnMenu == -1)
                {
                    AppendOrCreateTXT.TXT(TotalChek, TotalPrice);
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Спасибо за заказ! Нажмите Escape, если хотите сделать ещё заказ");
                        if (Console.ReadKey().Key.ToString() == "Escape")
                        {
                            Contentcheque.Clear();
                            break;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                }
                else if (inputKey == "Enter")
                {
                    if (Content.ReturnMenu == -1) Content.ReturnMenu = Select;
                    else
                    {
                        Contentcheque.Add(new TotalList() { title = CrutchTitle, totalName = CrutchName, price = CrutchPrice });
                        Content.ReturnMenu = -1;
                    }
                }
                else if (inputKey == "UpArrow" && Select < Counter-1)
                {
                    Select += 1;
                }
                else if (inputKey == "Esc")
                {
                    Content.ReturnMenu = -1;
                }
            }
        }
    }
}

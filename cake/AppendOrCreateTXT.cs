using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cake
{
    internal class AppendOrCreateTXT
    {
        public static void TXT(string txt, int chek)
        {
            string path = "C:\\Users\\Lysikov\\Desktop\\Заказы.txt";
            if (File.Exists(path))
            {
                File.AppendAllText("C:\\Users\\Lysikov\\Desktop\\Заказы.txt", "\n" + "Заказ от " + DateTime.Now + "\n" + "\t" + "Заказ:" + txt + "\n" + "\t" + "Цена:" + chek);
            }
            else
            {
                File.Create(path);
                File.AppendAllText("C:\\Users\\Lysikov\\Desktop\\Заказы.txt", "\n" + "Заказ от " + DateTime.Now + "\n" + "\t" + "Заказ:" + txt + "\n" + "\t" + "Цена:" + chek);
            }
        }
    }
}

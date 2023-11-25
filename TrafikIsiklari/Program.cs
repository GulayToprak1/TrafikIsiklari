using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikIsiklari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool key = false;
            do
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1-Kırmızı 2-Sarı 3-Yeşil \n-------------------------\nYukarıdaki renklerden birini seçiniz:");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Kırmızı\nLütfen Bekleyiniz.");
                        key = true;

                        break;

                    case "2":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Sarı\nHazırlanın.");
                        key = true;
                        break;
                    case "3":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Yeşil\nGeçebilirsiniz.");
                        key = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Hatalı Seçim Yaptınız.Tekrar Deneyiniz..");

                        break;
                }

            } while (key == false);
            Console.ReadKey();
        }
    }
}

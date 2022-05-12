using System;
using System.IO;
namespace ConsoleApp3
{
    struct Smartphone
    {
        public string marka;

        public string model;

        public int price;

    }
    class DeviceShop
    {
        static void Main(string[] args)
        {
            Smartphone obj = new Smartphone();

            int a, b = 0;

            Console.Write("Введите размер массива = ");

            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Ошибка ввода! Введитее ещё раз = ");
            }
            object[] mas = new object[a * 4];

            for (int i = 0; i < a; i++)
            {
                Console.Write("Введите марку = ");

                obj.marka = Console.ReadLine();

                mas[b] = obj.marka;

                b++;

                Console.Write("Введите модель = ");

                obj.model = Console.ReadLine();

                mas[b] = obj.model;

                b++;

                Console.Write("Введите цену = ");

                while (!int.TryParse(Console.ReadLine(), out obj.price))
                {

                }
                mas[b] = obj.price;
                b++;

            }
            StreamWriter c = new StreamWriter("DeviceShop.txt");
            b = 0;
            for (int i = 0; i < a; i++)
            {
                c.WriteLine("Марка: " + mas[b]); b++;
                c.WriteLine("Модель: " + mas[b]); b++;
                c.WriteLine("Цена: " + mas[b]); b++;
            }
            c.Close();
        }
    }


}
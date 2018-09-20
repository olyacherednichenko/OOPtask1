using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            output company = new output();
            Console.WriteLine("1 Вывести futures_tick_data.csv \n2 Вывести spot_tick_data.csv \n3 Выход");

            int i = 0;
            do
            {
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("1 Вывести futures_tick_data.csv \n2 Вывести spot_tick_data.csv \n3 Выход");
                        //i = int.Parse(Console.ReadLine());
                        break;
                    case 1:
                        Console.Clear();
                        company.text("futures_tick_data.csv");
                        Console.WriteLine("0 Назад \n1 Вывести futures_tick_data.csv \n2 Вывести spot_tick_data.csv \n3 Выход");                         
                        break;
                    case 2:
                        Console.Clear();
                        company.text("spot_tick_data.csv");
                        Console.WriteLine("0 Назад \n1 Вывести futures_tick_data.csv \n2 Вывести spot_tick_data.csv \n3 Перейти к началу документа \n4 Перейти в конец документа \n5 Выход");
                        //i = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
             
                }
            } while (i < 3);

    }
    }

    class output
    {
        public void text(string namestxt)
        {
            string[] lines = File.ReadAllLines(namestxt);
            foreach (var line in lines) //Перебираем все элементы массива lines. Для каждого значения будет вызываться код, находящийся ниже
                Console.WriteLine(line); //Собственно выводим в консоль строку

        }

    }

}


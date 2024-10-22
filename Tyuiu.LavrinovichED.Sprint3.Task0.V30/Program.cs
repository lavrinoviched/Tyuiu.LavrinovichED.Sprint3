﻿using Tyuiu.LavrinovichED.Sprint3.Task0.V30.Lib;

namespace Tyuiu.LavrinovichED.Sprint3.Task0.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                   *");
            Console.WriteLine("* Тема: Оператор цикла for                                                                    *");
            Console.WriteLine("* Задание #0                                                                                  *");
            Console.WriteLine("* Вариант #30                                                                                 *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                  *");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
            Console.WriteLine("* Написать программу, используя цикл for, которая вычисляет произведение ряда по формуле      *");
            Console.WriteLine("*                                                                                             *");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
            Console.WriteLine("***********************************************************************************************");

            int startValue = 1;
            int stopValue = 20;

            Console.WriteLine(" Старт шага = " + startValue);
            Console.WriteLine(" Конец шага = " + stopValue);

            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
            Console.WriteLine("***********************************************************************************************");

            Console.WriteLine(" Сумма ряда = " + ds.GetMultiplySeries(startValue, stopValue));
            Console.ReadKey(); 
        }
    }
}

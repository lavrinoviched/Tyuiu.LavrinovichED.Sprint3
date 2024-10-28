﻿using Tyuiu.LavrinovichED.Sprint3.Task5.V20.Lib; 

namespace Tyuiu.LavrinovichED.Sprint3.Task5.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                        *");
            Console.WriteLine("* Тема: Вложенные циклы                                                                            *");
            Console.WriteLine("* Задание #5                                                                                       *");
            Console.WriteLine("* Вариант #20                                                                                      *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму ряда по формуле                                      *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 6; 

            Console.WriteLine(" Переменная Х = " + x);
            Console.WriteLine(" Старт шага первой суммы ряда = " + startValue1);
            Console.WriteLine(" Конец шага первой суммы ряда = " + stopValue1);
            Console.WriteLine(" Старт шага второй суммы ряда = " + startValue2);
            Console.WriteLine(" Конец шага второй суммы ряда = " + stopValue2);

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine(" Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2));

            Console.ReadKey(); 
        }
    }
}

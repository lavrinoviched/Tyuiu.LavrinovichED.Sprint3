using Tyuiu.LavrinovichED.Sprint3.Task2.V3.Lib; 

namespace Tyuiu.LavrinovichED.Sprint3.Task2.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                        *");
            Console.WriteLine("* Тема: Оператор цикла do -  while                                                                 *");
            Console.WriteLine("* Задание #2                                                                                       *");
            Console.WriteLine("* Вариант #3                                                                                       *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Написать программу, используя цикл do...while, которая вычисляет произведение ряда по формуле    *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            int value = 4;
            int startValue = 1;
            int stopValue = 15;

            Console.WriteLine(" Переменная Х = " + value); 
            Console.WriteLine(" Старт шага = " + startValue); 
            Console.WriteLine(" Конец шага = " + stopValue);


            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
            Console.WriteLine("***********************************************************************************************");

            Console.WriteLine(" Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));

            Console.ReadKey(); 
        }
    }
}

using Tyuiu.LavrinovichED.Sprint3.Task1.V18.Lib; 

namespace Tyuiu.LavrinovichED.Sprint3.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                   *");
            Console.WriteLine("* Тема: Оператор цикла while                                                                  *");
            Console.WriteLine("* Задание #1                                                                                  *");
            Console.WriteLine("* Вариант #18                                                                                 *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                  *");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
            Console.WriteLine("* Написать программу, используя цикл while, которая вычисляет произведение ряда по формуле    *");
            Console.WriteLine("*                                                                                             *");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
            Console.WriteLine("***********************************************************************************************");

            int startValue = 1;
            int stopValue = 15;

            Console.WriteLine(" Старт шага = " + startValue);
            Console.WriteLine(" Конец шага = " + stopValue);

            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
            Console.WriteLine("***********************************************************************************************");

            Console.WriteLine(" Сумма ряда = " + ds.GetSumSeries(startValue, stopValue)); 
            Console.ReadKey();
        }
    }
}

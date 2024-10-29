using Tyuiu.LavrinovichED.Sprint3.Task7.V21.Lib;

namespace Tyuiu.LavrinovichED.Sprint3.Task7.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                        *");
            Console.WriteLine("* Тема: Добавление к решению интоговых проектов по спринту                                         *");
            Console.WriteLine("* Задание #7                                                                                       *");
            Console.WriteLine("* Вариант #21                                                                                      *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значенрий функции f(x) на заданном диапазоне         *");
            Console.WriteLine("* [-5; 5] с шагом 1. Произвести проверку деления на ноль                                           *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            Console.WriteLine("+----------+--------------+");
            Console.WriteLine("|    X     |    f(x)      |");
            Console.WriteLine("+----------+--------------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1, 6:f2}      |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+--------------+");
            Console.ReadKey();


        }
    }
}

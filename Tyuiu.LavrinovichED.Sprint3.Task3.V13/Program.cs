using Tyuiu.LavrinovichED.Sprint3.Task3.V13.Lib; 

namespace Tyuiu.LavrinovichED.Sprint3.Task3.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                        *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                                                     *");
            Console.WriteLine("* Задание #3                                                                                       *");
            Console.WriteLine("* Вариант #13                                                                                      *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Написать программу, используя цикл foreach, удалить все буквы и знаки препинания, оставить цифру *");
            Console.WriteLine("* затем преобразовать в число в строке: ?ds!! 5gh.s!                                               *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            string value = "?ds!! 5gh.s!";
            int wait = 5;

            Console.WriteLine(" Исходная строка = " + value);
            Console.WriteLine(" Искомый символ = " + wait);

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine(" Символ = " + ds.ConvertStringToInt(value));

            Console.ReadKey();
        }
    }
}

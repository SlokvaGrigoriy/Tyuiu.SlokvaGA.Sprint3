using Tyuiu.SlokvaGA.Sprint3.Task1.V6.Lib;

namespace Tyuiu.SlokvaGA.Sprint3.Task1.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Слоква Г. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Оператор цикла while                                             *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Слоква Г. А. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет             *");
            Console.WriteLine("* сумму ряда по формуле, при a=4                                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int value = 4;
            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine("Переменная a = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}

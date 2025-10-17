using Tyuiu.SlokvaGA.Sprint3.Task2.V11.Lib;

namespace Tyuiu.SlokvaGA.Sprint3.Task2.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Слоква Г. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                          *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #11                                                            *");
            Console.WriteLine("* Выполнил: Слоква Г. А. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет        *");
            Console.WriteLine("* сумму ряда по формуле, при х=0,5                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double value = 0.5;
            int startValue = 1;
            int stopValue = 15;
            Console.WriteLine("Переменная x = " + value);
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

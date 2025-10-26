using Tyuiu.SlokvaGA.Sprint3.Task7.V12.Lib;

namespace Tyuiu.SlokvaGA.Sprint3.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Слоква Г. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #12                                                            *");
            Console.WriteLine("* Выполнил: Слоква Г. А. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:          *");
            Console.WriteLine("*                    2                                                   *");
            Console.WriteLine("* f(x) = sin(x) + ------ - 2сos(x) * 2x                                  *");
            Console.WriteLine("*                 3x+0,5                                                 *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5;5] с шагом 1.*");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть       *");
            Console.WriteLine("* значение 0. Значения занести в массив. Значения округлить до двух      *");
            Console.WriteLine("* знаков после запятой.                                                  *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            double[] valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
            Console.WriteLine("************************************************************");

            Console.WriteLine("+----------+------------+");
            Console.WriteLine("|    x     |    f(x)    |");
            Console.WriteLine("+----------+------------+");

            for (int i = 0; i < valueArray.Length; i++)
            {
                int currentX = startValue + i;
                Console.WriteLine($"| {currentX,5}    | {valueArray[i],10:F2} |");
            }

            Console.WriteLine("+----------+------------+");
            Console.ReadKey();
        }
    }
}

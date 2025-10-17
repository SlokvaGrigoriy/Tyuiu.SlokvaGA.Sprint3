using Tyuiu.SlokvaGA.Sprint3.Task3.V26.Lib;

namespace Tyuiu.SlokvaGA.Sprint3.Task3.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Слоква Г. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                           *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #26                                                            *");
            Console.WriteLine("* Выполнил: Слоква Г. А. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Используя цикл foreach подсчитать количество букв “e” в строке:        *");
            Console.WriteLine("* have a nice time                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string value = "have a nice time";
            char letter = 'e';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Исходный символ = " + letter);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetCharCount(value, letter));
            Console.ReadKey();
        }
    }
}
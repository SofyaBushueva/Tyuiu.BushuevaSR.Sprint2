using Tyuiu.BushuevaSR.Sprint2.Task1.V30.Lib;
namespace Tyuiu.BushuevaSR.Sprint2.Task1.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 657;
            int b = 874;
            int c = 14;
            int d = 654;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Бушуева С.Р. | ПИНб-26-1 ";

            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                     *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                              *");
            Console.WriteLine("* Задание #1                                                                                                    *");
            Console.WriteLine("* Вариант #30                                                                                                   *");
            Console.WriteLine("* Выполнила: Бушуева Софья Романовна | ПИНб-26-1                                                                *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                      *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать,          *");
            Console.WriteLine("* но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^,                              *");
            Console.WriteLine("* последовательность операций не должна нарушаться), а также арифметических выражений,                          *");
            Console.WriteLine("*которая вернет логическую последовательность(массив): (True, False, True, True, True, False),                  *");
            Console.WriteLine("*при a = 657, b = 874, c = 14, d = 654                                                                          *");
            Console.WriteLine("*                                                                                                               *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("*****************************************************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                    *");
            Console.WriteLine("*****************************************************************************************************************");

            for (int i = 0; i < 6; i++)

            {
                Console.WriteLine(res[i]);

            }

            Console.ReadKey();

        }

    }
}

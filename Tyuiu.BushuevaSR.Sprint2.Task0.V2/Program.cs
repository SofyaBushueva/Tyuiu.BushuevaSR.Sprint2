using Tyuiu.BushuevaSR.Sprint2.Task0.V2.Lib;
namespace Tyuiu.BushuevaSR.Sprint2.Task0.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 123;
            int y = 123;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #1 | Выполнил: Бушуева С.Р. | ПИНб-26-1 ";

            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                     *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                              *");
            Console.WriteLine("* Задание #0                                                                                                    *");
            Console.WriteLine("* Вариант #0                                                                                                    *");
            Console.WriteLine("* Выполнила: Бушуева Софья Романовна | ПИНб-26-1                                                                *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                      *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 48 / 12 - 48 / 6 / 4                                                  *");
            Console.WriteLine("*и печатает результат на экране.                                                                                *");
            Console.WriteLine("*                                                                                                               *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("*****************************************************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

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

using Tyuiu.BushuevaSR.Sprint2.Task4.V1.Lib;
namespace Tyuiu.BushuevaSR.Sprint2.Task4.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #2 | Выполнил: Бушуева С.Р. | ПИНб-26-1 ";

            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                     *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                              *");
            Console.WriteLine("* Задание #4                                                                                                    *");
            Console.WriteLine("* Вариант #1                                                                                                    *");
            Console.WriteLine("* Выполнила: Бушуева Софья Романовна | ПИНб-26-1                                                                *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                      *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием тернарного оператара,               *");
            Console.WriteLine("* где пользователь вводит вводит значение переменных x, y с клавиатуры,                                         *");
            Console.WriteLine("* если x < y, то z = (x + 3) / y, иначе (x + 1) / (x - 2).                                                      *");
            Console.WriteLine("*Округлить полученное значение до 3 знаков после запятой.                                                       *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("*****************************************************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                    *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
    }
}

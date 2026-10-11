using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BushuevaSR.Sprint2.Task3.V24.Lib
{
    public class DataService : ISprint2Task3V24
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0)
            {
                y = Math.Round(Math.Pow(x * ((10 + Math.Sin(Math.Sqrt(x + 1))) / x), x), 3);
            }
            else
            {
                if (x == 0)
                {
                    y = Math.Cos(x) + (12 / (Math.Pow(x, 2)));

                }
                else
                {
                    if ((x > -28) && (x < 0))
                    {
                        y = Math.Round (Math.Pow(1 + (1 / (Math.Pow(x, 2))), x), 1);

                    }
                    else
                    {
                        if (x < -28)
                        {
                            y = Math.Round (Math.Pow(x, 2) + 10 * x - (1 / x), 3);
                        }
                    }

                }

            }
            return Math.Round(y, 3);
        }
    }
}

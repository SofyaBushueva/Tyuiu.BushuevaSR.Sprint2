using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BushuevaSR.Sprint2.Task2.V22.Lib
{
    public class DataService : ISprint2Task2V22
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;
            if (((x >= 3) && (x <= 5) || (x >= 9) && (x <= 12)) && (y >= 3) && (y <= 4))
            {
                res = true;
            }



            else if ((x >= 3) && (x <= 12) && (y == 5))
            {
                res = true;
            }



            else if ((x >= 3) && (x <= 13) && (y >= 6) && (y <= 7))
            {
                res = true;
            }



            else if ((x >= 4) && (x <= 6) && (y >= 8) && (y <= 10))
            {
                res = true;
            }


            else if ((x >= 9) && (x <= 10) && (y >= 8) && (y <= 9))
            {
                res = true;
            }

            else if ((y == 8) && (x >= 12) && (x <= 13))
            {
                res = true;
            }


            else if ((y >= 9) && (y <= 11) && (x == 12))
            {
                res = true;
            }


            else if ((y == 11) && (x >= 3) && (x <= 6))
            {
                res = true;
            }


            else if ((x == 5) && (y >= 12) && (y <= 13))
            {
                res = true;
            }


            else if ((x >= 4) && (x <= 10) && (y == 14))
            {
                res = true;
            }
            
            return res;

        }   
    }
}

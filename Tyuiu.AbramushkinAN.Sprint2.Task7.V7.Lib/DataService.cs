using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AbramushkinAN.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double check1, check2;
            check1 = 2-Math.Pow(x, 2);
            check2 = x;
            if (((check1>=y)) && (y>=0 && y<=2) && ((check2>y) || (x>=0 && y>0)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

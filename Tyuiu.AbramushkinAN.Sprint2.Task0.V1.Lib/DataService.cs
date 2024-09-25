using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AbramushkinAN.Sprint2.Task0.V1.Lib
{
    public class DataService : ISprint2Task0V1
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y + 111;
            res[1] = x != y + 111;
            res[2] = y < x;
            res[3] = y > x;
            res[4] = y <= x;
            res[5] = y >= x;
            return res;
        }
    }
}

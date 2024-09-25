using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AbramushkinAN.Sprint2.Task1.V9.Lib
{
    public class DataService : ISprint2Task1V9
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            result[0] = (a == b) | (c==d);
            result[1] = (a<b-321) & (c > d);   
            result[2] = (a!=b) || (c!=d);
            result[3] = (a>=b) && (c<=d);
            result[4] = !(result[0]);
            result[5] = (a>=b) ^ (c>=d);

            return result;
        }
    }
}

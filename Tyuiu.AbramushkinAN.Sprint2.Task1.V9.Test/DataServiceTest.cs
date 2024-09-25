using Tyuiu.AbramushkinAN.Sprint2.Task1.V9.Lib;
namespace Tyuiu.AbramushkinAN.Sprint2.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            bool[] result = new bool[6];
            int a = 15;
            int b = 335;
            int c = 174;
            int d = 478;

            result = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] {false, false, true, false, true, false};


            CollectionAssert.AreEqual(wait, result);
        }
    }
}
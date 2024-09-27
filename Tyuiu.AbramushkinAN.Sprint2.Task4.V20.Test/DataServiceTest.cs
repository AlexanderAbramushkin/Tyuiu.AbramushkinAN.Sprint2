using Tyuiu.AbramushkinAN.Sprint2.Task4.V20.Lib;

namespace Tyuiu.AbramushkinAN.Sprint2.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double wait = 0.173;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 10;
            double wait = 24.9;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
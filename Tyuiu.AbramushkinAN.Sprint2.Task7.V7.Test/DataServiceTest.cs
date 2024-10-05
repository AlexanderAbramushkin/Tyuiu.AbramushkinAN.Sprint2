using Tyuiu.AbramushkinAN.Sprint2.Task7.V7.Lib;
namespace Tyuiu.AbramushkinAN.Sprint2.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1.25;
            double y = 0;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);

        }

        [TestMethod]
        public void CheckNotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = 2;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(false, res);

        }
    }
}
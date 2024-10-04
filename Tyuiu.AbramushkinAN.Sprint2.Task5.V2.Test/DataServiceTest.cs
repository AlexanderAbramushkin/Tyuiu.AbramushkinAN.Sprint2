using Tyuiu.AbramushkinAN.Sprint2.Task5.V2.Lib;
namespace Tyuiu.AbramushkinAN.Sprint2.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckTimeOfYear()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Зима",ds.FindMonthSeason(12));
            Assert.AreEqual("Зима", ds.FindMonthSeason(1));
            Assert.AreEqual("Зима", ds.FindMonthSeason(2));
            Assert.AreEqual("Весна", ds.FindMonthSeason(3));
            Assert.AreEqual("Весна", ds.FindMonthSeason(4));
            Assert.AreEqual("Весна", ds.FindMonthSeason(5));
            Assert.AreEqual("Лето", ds.FindMonthSeason(6));
            Assert.AreEqual("Лето", ds.FindMonthSeason(7));
            Assert.AreEqual("Лето", ds.FindMonthSeason(8));
            Assert.AreEqual("Осень", ds.FindMonthSeason(9));
            Assert.AreEqual("Осень", ds.FindMonthSeason(10));
            Assert.AreEqual("Осень", ds.FindMonthSeason(11));

            Assert.ThrowsException<ArgumentException>(() => ds.FindMonthSeason(-1));
            Assert.ThrowsException<ArgumentException>(() => ds.FindMonthSeason(13));
        }
    }
}
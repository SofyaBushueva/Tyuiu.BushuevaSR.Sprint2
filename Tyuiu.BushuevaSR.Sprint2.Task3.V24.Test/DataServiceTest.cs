using Tyuiu.BushuevaSR.Sprint2.Task3.V24.Lib;
namespace Tyuiu.BushuevaSR.Sprint2.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            int x = 1;
            double res = ds.Calculate(x);
            double wait = 10.988;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            int x = 0;
            double res = ds.Calculate(x);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            int x = -1;
            double res = ds.Calculate(x);
            double wait = 0.5;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            int x = -29;
            double res = ds.Calculate(x);
            double wait = 551.034;
            Assert.AreEqual(wait, res);
        }

    }
}

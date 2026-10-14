using Tyuiu.BushuevaSR.Sprint2.Task4.V1.Lib;
namespace Tyuiu.BushuevaSR.Sprint2.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 7;
            double y = 11;
            double res = ds.Calculate(x, y);
            double wait = 0.909;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 11;
            double y = 8;
            double res = ds.Calculate(x, y);
            double wait = 1.333;
            Assert.AreEqual(wait, res);
        }
    }


}

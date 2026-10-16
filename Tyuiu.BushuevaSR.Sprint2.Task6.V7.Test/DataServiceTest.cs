using System;
using Tyuiu.BushuevaSR.Sprint2.Task6.V7.Lib;
namespace Tyuiu.BushuevaSR.Sprint2.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("январь", ds.FindMonthName(1990, 1));
            Assert.AreEqual("февраль", ds.FindMonthName(1990, 2));
            Assert.AreEqual("март", ds.FindMonthName(1990, 3));
            Assert.AreEqual("апрель", ds.FindMonthName(1990, 4));
            Assert.AreEqual("май", ds.FindMonthName(1990, 5));
            Assert.AreEqual("июнь", ds.FindMonthName(1990, 6));
            Assert.AreEqual("июль", ds.FindMonthName(1990, 7));
            Assert.AreEqual("август", ds.FindMonthName(1990, 8));
            Assert.AreEqual("сентябрь", ds.FindMonthName(1990, 9));
            Assert.AreEqual("октябрь", ds.FindMonthName(1990, 10));
            Assert.AreEqual("ноябрь", ds.FindMonthName(1990, 11));
            Assert.AreEqual("декабрь", ds.FindMonthName(1990, 12));

            try
            {
                ds.FindMonthName(1990, -1);
                Assert.Fail("Ожидается ArgumentException для месяца -1");
            }
            catch (ArgumentException) { }

            try
            {
                ds.FindMonthName(1990, 13);
                Assert.Fail("Ожидается ArgumentException для месяца 13");
            }
            catch (ArgumentException) { }
        }
    }
}

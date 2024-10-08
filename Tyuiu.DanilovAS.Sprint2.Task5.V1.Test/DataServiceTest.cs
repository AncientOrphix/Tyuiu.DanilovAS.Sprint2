using Tyuiu.DanilovAS.Sprint2.Task5.V1.Lib;

namespace Tyuiu.DanilovAS.Sprint2.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFindMonthDaysCount()
        {
            DataService ds = new DataService();
            int value = 1;
            var wait = 31;
            var res = ds.FindMonthDaysCount(value);
            Assert.AreEqual(res,wait);
        }
    }
}
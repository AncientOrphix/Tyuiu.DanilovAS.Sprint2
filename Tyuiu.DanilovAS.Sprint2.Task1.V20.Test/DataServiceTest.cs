using Tyuiu.DanilovAS.Sprint2.Task1.V20.Lib;

namespace Tyuiu.DanilovAS.Sprint2.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetLogicOperations()
        {
            DataService ds = new DataService();

            int a = 242;
            int b = 155;
            int c = 456;
            int d = 17;

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            bool[] wait = new bool[6];
            wait[0] =false;
            wait[1] = false;
            wait[2] = false;
            wait[3] = true;
            wait[4] = true;
            wait[5] = true;

            CollectionAssert.AreEqual(res, wait);
        }
    }
}
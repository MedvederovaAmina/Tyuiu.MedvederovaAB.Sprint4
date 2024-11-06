using Tyuiu.MedvederovaAB.Sprint4.Task2.V1.Lib;

namespace Tyuiu.MedvederovaAB.Sprint4.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            int res = ds.Calculate(array);
            int wait = 384;
            Assert.AreEqual(wait, res);
        }
    }
}
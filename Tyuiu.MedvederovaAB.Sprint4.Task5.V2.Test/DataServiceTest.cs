using Tyuiu.MedvederovaAB.Sprint4.Task5.V2.Lib;

namespace Tyuiu.MedvederovaAB.Sprint4.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 4, 3, -6, 5, 5 }, { 3, 4, 4, -6, 4 }, { -6, 4, -6, 4, 5 }, { -1, -7, 4, -2, 5 }, { 3, -5, -6, 4, -6 } };
            int res = ds.Calculate(matrix);
            int wait = 10;
            Assert.AreEqual(wait, res);
        }
    }
}
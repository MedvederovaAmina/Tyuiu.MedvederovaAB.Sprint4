namespace Tyuiu.MedvederovaAB.Sprint4.Task6.V1.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()
    {
        DataService ds = new DataService();
        var array = new string[] { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };
        int res = ds.Calculate(array);
        int wait = 2;
        Assert.AreEqual(wait, res);
    }

}
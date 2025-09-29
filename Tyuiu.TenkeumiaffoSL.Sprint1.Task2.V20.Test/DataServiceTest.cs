using Tyuiu.TenkeumiaffoSL.Sprint1.Task2.V20.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint1.Task2.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value1 = 3;
            int value2 = 4;
            var res = ds.CalculateSquaresSumm(value1, value2);
            Assert.AreEqual(25, res); 
        }

       
    }
}
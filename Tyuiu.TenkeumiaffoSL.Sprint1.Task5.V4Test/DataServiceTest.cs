using Tyuiu.TenkeumiaffoSL.Sprint1.Task5.V4.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int time = 13257;
            var res = ds.SecondsToHours(time);
            Assert.AreEqual(3, res); 
        }

      
    }
}
using Tyuiu.TenkeumiaffoSL.Sprint1.Task6.V1.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint1.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "ABC";
            var res = ds.SymbolCode(value);
            Assert.AreEqual("'A' = 65, 'B' = 66, 'C' = 67", res);
        }



    }
}
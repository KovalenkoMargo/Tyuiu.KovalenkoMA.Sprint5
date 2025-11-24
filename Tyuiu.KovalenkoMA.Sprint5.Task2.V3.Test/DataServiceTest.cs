using Tyuiu.KovalenkoMA.Sprint5.Task2.V3.Lib;
namespace Tyuiu.KovalenkoMA.Sprint5.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mx = new int [3,3] { { 5, 9, 1 }, { 1, 3, 9 }, { 1, 2, 2 } };

            string path = ds.SaveToFileTextData(mx);
            FileInfo fileinto = new FileInfo(path);
            bool fileExists = fileinto.Exists;
            Assert.AreEqual(true, fileExists); 
        }
    }
}

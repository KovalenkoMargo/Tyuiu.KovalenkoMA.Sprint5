using Tyuiu.KovalenkoMA.Sprint5.Task4.V27.Lib;
namespace Tyuiu.KovalenkoMA.Sprint5.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:\DataSprint5\InPutDataFileTask4V27.txt";
            FileInfo fileinto = new FileInfo(path);
            bool fileExists = fileinto.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}

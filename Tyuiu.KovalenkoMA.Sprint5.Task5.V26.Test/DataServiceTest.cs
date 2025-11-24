using Tyuiu.KovalenkoMA.Sprint5.Task5.V26.Lib;
namespace Tyuiu.KovalenkoMA.Sprint5.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:\DataSprint5\InPutDataFileTask5V26.txt";
            FileInfo fileinto = new FileInfo(path);
            bool fileExists = fileinto.Exists;
            Assert.AreEqual(true, fileExists);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string path = $@"C:\DataSprint5\InPutDataFileTask5V26.txt";
            FileInfo fileinto = new FileInfo(path);
            bool fileExists = fileinto.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}

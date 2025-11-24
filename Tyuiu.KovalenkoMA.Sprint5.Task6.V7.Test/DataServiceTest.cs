using Tyuiu.KovalenkoMA.Sprint5.Task6.V7.Lib;
namespace Tyuiu.KovalenkoMA.Sprint5.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:\DataSprint5\InPutDataFileTask6V7.txt";
            FileInfo fileinto = new FileInfo(path);
            bool fileExists = fileinto.Exists;
            Assert.AreEqual(true, fileExists);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint5\InPutDataFileTask6V7.txt";

            Assert.AreEqual(16, ds.LoadFromDataFile(path));
        }
    }
}

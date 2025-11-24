using Tyuiu.KovalenkoMA.Sprint5.Task1.V30.Lib;
namespace Tyuiu.KovalenkoMA.Sprint5.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int srtV = -5;
            int stpV = 5 ;

            string path = ds.SaveToFileTextData(srtV,stpV);
            FileInfo fileinto = new FileInfo(path);
            bool fileExists = fileinto.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
    
}

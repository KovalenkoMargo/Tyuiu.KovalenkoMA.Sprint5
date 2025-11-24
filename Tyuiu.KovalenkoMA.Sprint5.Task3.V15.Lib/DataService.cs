using System.Text.Unicode;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KovalenkoMA.Sprint5.Task3.V15.Lib
{
    public class DataService : ISprint5Task3V15
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            

            double y = Math.Round(( -1.4 * Math.Pow(x,3) + 2.3 * Math.Pow(x,2) + 0.6 * x ), 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(y);
            }


            return path;
        }
    }
}

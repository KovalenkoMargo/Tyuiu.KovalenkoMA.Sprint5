using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KovalenkoMA.Sprint5.Task1.V30.Lib
{
    public class DataService : ISprint5Task1V30
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            for (int x = startValue; x <= stopValue; x++) 
            {
                if (x == 1)
                {
                    y = 0;
                }
                else
                {
                     y = Math.Round((Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - 4 * x), 2);
                }
                string strV = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path, strV + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strV);
                }
            }
            return path;
        }
    }
}

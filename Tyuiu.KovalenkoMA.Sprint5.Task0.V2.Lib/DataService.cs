using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KovalenkoMA.Sprint5.Task0.V2.Lib
{
    public class DataService : ISprint5Task0V2
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double y = Math.Round((Math.Exp(x)/x),3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;


        }
    }
}

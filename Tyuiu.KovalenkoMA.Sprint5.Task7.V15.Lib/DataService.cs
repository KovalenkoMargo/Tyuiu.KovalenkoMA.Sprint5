using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KovalenkoMA.Sprint5.Task7.V15.Lib
{
    public class DataService : ISprint5Task7V15
    {
        public string LoadDataAndSave(string path)
        {
            string res = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');

                    foreach (string word in words)
                    {
                        if (word.Length != 2)
                        {
                            res += word + " ";
                        }
                    }
                }
            }
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V15.txt");
            File.WriteAllText(outputPath, res.ToString().Trim());

            return outputPath;
        }
    }
}

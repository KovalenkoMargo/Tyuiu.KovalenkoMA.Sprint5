using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KovalenkoMA.Sprint5.Task6.V7.Lib
{
    public class DataService : ISprint5Task6V7
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while (( line = reader.ReadLine()) != null)
                {
                    string str = Convert.ToString(line);
                    foreach (char с in str)
                    {
                        if (char.IsLower(с) && ((с >= 'a' && с <= 'z')))
                        {
                            res++;
                        }
                    }
                }
            }
            return res;
        }
    }
}

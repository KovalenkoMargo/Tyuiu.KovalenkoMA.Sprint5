using Tyuiu.KovalenkoMA.Sprint5.Task3.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int x = 5;
        string path = ds.SaveToFileTextData(x);
        double result;
        using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
        {
            result = reader.ReadDouble();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine($"* Результат: {result}                                                    *");
        Console.WriteLine($"* Файл сохранен: {path}                                                  *");

        Console.ReadKey();
    }
}
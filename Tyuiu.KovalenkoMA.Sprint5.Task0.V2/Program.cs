using Tyuiu.KovalenkoMA.Sprint5.Task0.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #2                                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int x = 3;
        string path = ds.SaveToFileTextData(x);
        string result = File.ReadAllText(path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine($"* Результат: {result}                                                    *");
        Console.WriteLine($"* Файл сохранен: {path}                                                  *");

        Console.ReadKey();
    }
}
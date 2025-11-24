using Tyuiu.KovalenkoMA.Sprint5.Task7.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        string path = $@"C:\DataSprint5\InPutDataFileTask7V15.txt";
        Console.WriteLine($"* Файл сохранен: {path}                                                  *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine($"* Результат: {ds.LoadDataAndSave(path)}                                 *");


        Console.ReadKey();
    }
}
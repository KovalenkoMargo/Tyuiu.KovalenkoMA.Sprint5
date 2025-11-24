using Tyuiu.KovalenkoMA.Sprint5.Task4.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #27                                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        string path = $@"C:\DataSprint5\InPutDataFileTask4V27.txt";
        Console.WriteLine($"* Файл сохранен: {path}                                                  *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        
        Console.WriteLine($"* Результат: {ds.LoadFromDataFile(path)}                                 *");
        

        Console.ReadKey();
    }
}
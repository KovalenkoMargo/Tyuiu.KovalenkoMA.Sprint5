using Tyuiu.KovalenkoMA.Sprint5.Task2.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ВВЕДИТЕ ИСХОДНЫЕ ДАННЫЕ:                                                *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        int[,] mx = new int[3,3];
        for (int i = 0; i < 3 ; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"введите значение строки {i} и столбца {j}");
                mx[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string path = ds.SaveToFileTextData(mx);

        Console.WriteLine($"* Файл сохранен: {path}*");

        Console.ReadKey();
    }
}
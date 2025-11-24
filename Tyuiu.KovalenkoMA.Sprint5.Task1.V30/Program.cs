using Tyuiu.KovalenkoMA.Sprint5.Task1.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int srtV = -5;
        int stpV = 5;
        Console.WriteLine("startValue = " + srtV);
        Console.WriteLine("stopValue = " + stpV);
        string path = ds.SaveToFileTextData(srtV, stpV);
        

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("+-----------+----------+");
        Console.WriteLine("|    X      |    f(x)  |");
        Console.WriteLine("+-----------+----------+");

        for (int x = srtV; x <= stpV; x++)
        {
            double y;

            if (x == 1)
            {
                y = 0;
            }
            else
            {
                y = Math.Round(Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - 4 * x, 2);
            }

            Console.WriteLine($"|{x,5:d}     |  {y,5:f2}  |");
            Console.WriteLine("+-----------+----------+");
        }

        Console.WriteLine($"* Файл сохранен: {path}*");

        Console.ReadKey();
    }
}
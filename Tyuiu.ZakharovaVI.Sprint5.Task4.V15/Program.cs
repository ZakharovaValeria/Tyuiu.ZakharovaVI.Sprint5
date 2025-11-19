using Tyuiu.ZakharovaVI.Sprint5.Task4.V15.Lib;

namespace Tyuiu.ZakharovaVI.Sprint5.Task4.V15

{
    class Program
    {
        static void Main(string[] args)
        {
            
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Захарова В. И. | ИБКС-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Захарова Валерия Игоревна | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле             *");
            Console.WriteLine("* Вычислить значение по формуле и вернуть полученный результат на консоль *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V15.txt";
            Console.WriteLine("Данные находятся в файле:" + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
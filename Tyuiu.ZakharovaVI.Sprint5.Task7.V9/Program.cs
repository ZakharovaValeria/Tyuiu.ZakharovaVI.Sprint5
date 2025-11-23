using Tyuiu.ZakharovaVI.Sprint5.Task7.V9.Lib;

namespace Tyuiu.ZakharovaVI.Sprint5.Task7.V9

{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Захарова В. И. | ИБКС-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Захарова Валерия Игоревна | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти произведение всех двузначных чисел в файле                        *");
            Console.WriteLine("* Полученный результат вывести на консоль.                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V9.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";
            Console.WriteLine("Данные находятся в файле:" + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле:");

            pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
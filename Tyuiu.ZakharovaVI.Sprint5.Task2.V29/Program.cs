using Tyuiu.ZakharovaVI.Sprint5.Task2.V29.Lib;

namespace Tyuiu.ZakharovaVI.Sprint5.Task2.V29

{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[3, 3] { { 9, 2, 5 }, { 3, 2, 4 }, { 2, 8, 8 } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Захарова В. И. | ИБКС-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Захарова Валерия Игоревна | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов                     *");
            Console.WriteLine("* Заменить нечетные элементы массива на 0.                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }



            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

             
            string res = ds.SaveToFileTextData(mtrx);


            string resultFromFile = File.ReadAllText(res);

            Console.WriteLine("Результат:" + resultFromFile);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
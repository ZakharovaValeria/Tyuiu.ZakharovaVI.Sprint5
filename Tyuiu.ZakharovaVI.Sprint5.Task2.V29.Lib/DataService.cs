
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZakharovaVI.Sprint5.Task2.V29.Lib
{
    public class DataService : ISprint5Task2V29
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExsists = fileInfo.Exists;

            if (fileExsists)
            {
                File.Delete(path);
            }





            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            //int[,] res = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string str = "";
            for (int i = 0;i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j!= columns -1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                } 
                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }

                str = "";
            }
            return path;

        }
    }
}

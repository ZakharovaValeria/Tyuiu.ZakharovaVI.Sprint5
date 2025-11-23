using System.Threading.Tasks;

using System.Globalization;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZakharovaVI.Sprint5.Task6.V8.Lib
{
    public class DataService : ISprint5Task6V8
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    char[] separators = { ' ', '.', ',', '!', '?', ';', ':', '-', '\t', '\r' };
                    string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (word.Length == 2)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}

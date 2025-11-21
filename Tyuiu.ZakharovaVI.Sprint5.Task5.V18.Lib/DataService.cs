using System.Threading.Tasks;

using System.Globalization;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZakharovaVI.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            using  (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string numberstr in numbers)
                    {
                        if (double.TryParse(numberstr, out double num))
                        {
                            if (Math.Abs(num) >= 10 && Math.Abs(num) <= 100)
                            {
                                res = res * num;
                            }
                        }
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}

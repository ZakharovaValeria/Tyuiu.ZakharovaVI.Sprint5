using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZakharovaVI.Sprint5.Task3.V22.Lib
{
    public class DataService : ISprint5Task3V22
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double z = Math.Pow(1 - x, 2) / (-3 * x);

            z = Math.Round(z, 3); 

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create), Encoding.UTF8))
            { 
                //writer.Write(BitConverter.GetBytes(z));
                writer.Write(z);
            }

            return path;

        }
        
    }
}

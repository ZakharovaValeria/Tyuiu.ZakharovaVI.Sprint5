
using System.Globalization;

using System.IO;

using System.Text;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZakharovaVI.Sprint5.Task7.V9.Lib
{
    public class DataService : ISprint5Task7V9
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExsists = fileInfo.Exists; 

            if (fileExsists)
            {
                File.Delete(pathSaveFile); 
            }

            //string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string strLine = "";
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!(line[i] >= 'A' && line[i] <= 'Z'))
                        {
                            strLine += line[i];
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    //strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}

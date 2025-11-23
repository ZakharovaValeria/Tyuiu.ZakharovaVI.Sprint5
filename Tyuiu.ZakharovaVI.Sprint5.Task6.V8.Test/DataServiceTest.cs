using Tyuiu.ZakharovaVI.Sprint5.Task6.V8.Lib;

namespace Tyuiu.ZakharovaVI.Sprint5.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCale()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.ZakharovaVI.Sprint5\Tyuiu.ZakharovaVI.Sprint5.Task6.V8\bin\Debug\net8.0\InPutDataFileTask6V8.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);

        }

        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.ZakharovaVI.Sprint5\Tyuiu.ZakharovaVI.Sprint5.Task6.V8\bin\Debug\net8.0\InPutDataFileTask6V8.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExsists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsists);
        }
    }
}

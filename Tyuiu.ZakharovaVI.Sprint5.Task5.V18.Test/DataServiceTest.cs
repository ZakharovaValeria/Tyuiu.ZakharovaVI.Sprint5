using Tyuiu.ZakharovaVI.Sprint5.Task5.V18.Lib;

namespace Tyuiu.ZakharovaVI.Sprint5.Task5.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.ZakharovaVI.Sprint5\Tyuiu.ZakharovaVI.Sprint5.Task5.V18\bin\Debug\net8.0\InPutDataFileTask5V18.txt";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExsists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsists); 
        }
    }
}

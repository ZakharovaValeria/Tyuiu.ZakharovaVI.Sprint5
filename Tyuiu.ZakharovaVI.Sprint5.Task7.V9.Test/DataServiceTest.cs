using Tyuiu.ZakharovaVI.Sprint5.Task7.V9.Lib;

namespace Tyuiu.ZakharovaVI.Sprint5.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1() 
        {
            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.ZakharovaVI.Sprint5\Tyuiu.ZakharovaVI.Sprint5.Task7.V9\bin\Debug\net8.0\OutPutFileTask7.txt";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExsists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsists);
        }
    }
}

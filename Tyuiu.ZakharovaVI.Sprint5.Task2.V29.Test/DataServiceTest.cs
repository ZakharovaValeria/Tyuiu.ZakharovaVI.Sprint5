using Tyuiu.ZakharovaVI.Sprint5.Task2.V29.Lib;

namespace Tyuiu.ZakharovaVI.Sprint5.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\ТИУ\source\repos\Tyuiu.ZakharovaVI.Sprint5\Tyuiu.ZakharovaVI.Sprint5.Task2.V29\bin\Debug\OutPutFileTask2.txt";
             
            FileInfo fileInfo = new FileInfo(path);
            bool fileExsists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsists);

        }
    }
}

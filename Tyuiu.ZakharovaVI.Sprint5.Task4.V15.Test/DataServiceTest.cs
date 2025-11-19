using Tyuiu.ZakharovaVI.Sprint5.Task4.V15.Lib;

namespace Tyuiu.ZakharovaVI.Sprint5.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\ТИУ\source\repos\Tyuiu.ZakharovaVI.Sprint5\Tyuiu.ZakharovaVI.Sprint5.Task4.V15\bin\Debug\InPutDataFileTask4V15.txt";
           

            FileInfo fileInfo = new FileInfo(path);
            bool fileExsists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsists);
        }
    }
}

using Tyuiu.ZakharovaVI.Sprint5.Task3.V22.Lib;

namespace Tyuiu.ZakharovaVI.Sprint5.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1() 
        {
            string path = @"C:\Users\ТИУ\source\repos\Tyuiu.ZakharovaVI.Sprint5\Tyuiu.ZakharovaVI.Sprint5.Task3.V22\bin\Debug\OutPutFileTask3.bin";
             
            FileInfo fileInfo = new FileInfo(path);
            bool fileExsists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsists);
        }
    }
}

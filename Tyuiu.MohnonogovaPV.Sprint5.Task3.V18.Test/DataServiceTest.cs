using System.IO;
using Tyuiu.MohnonogovaPV.Sprint5.Task3.V18.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\“»”\source\repos\Tyuiu.MohnonogovaPV.Sprint5\Tyuiu.MohnonogovaPV.Sprint5.Task3.V18\bin\Debug\net8.0\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
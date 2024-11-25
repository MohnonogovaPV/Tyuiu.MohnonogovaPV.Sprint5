using System.IO;
using Tyuiu.MohnonogovaPV.Sprint5.Task0.V9.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\“»”\source\repos\Tyuiu.MohnonogovaPV.Sprint5\Tyuiu.MohnonogovaPV.Sprint5.Task0.V9\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
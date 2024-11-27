using System.IO;
using Tyuiu.MohnonogovaPV.Sprint5.Task7.V8.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\Полина\source\repos\Tyuiu.MohnonogovaPV.Sprint5\DataSprint5\InPutDataFileTask7V8.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
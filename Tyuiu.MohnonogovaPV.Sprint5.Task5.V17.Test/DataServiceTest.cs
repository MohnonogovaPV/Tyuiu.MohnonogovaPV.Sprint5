using System.IO;
using Tyuiu.MohnonogovaPV.Sprint5.Task5.V17.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\Полина\source\repos\Tyuiu.MohnonogovaPV.Sprint5\DataSprint5\InPutDataFileTask5V17.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
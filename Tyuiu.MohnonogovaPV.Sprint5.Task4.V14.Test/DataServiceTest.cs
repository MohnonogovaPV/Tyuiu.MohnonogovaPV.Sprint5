using System.IO;
using Tyuiu.MohnonogovaPV.Sprint5.Task4.V14.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.MohnonogovaPV.Sprint5\DataSprint5\InPutDataFileTask4V14.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
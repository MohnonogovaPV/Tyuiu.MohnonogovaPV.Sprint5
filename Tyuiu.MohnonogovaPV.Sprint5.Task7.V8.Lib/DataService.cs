using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V8.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(pathSaveFile);
            
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    strLine = line.ToLower();
                }
                File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                strLine = "";
            }
            return pathSaveFile;
        }
    }
}

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task0.V9.Lib
{
    public class DataService : ISprint5Task0V9
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double y = ((Math.Pow(x, 3))/(Math.Pow(x, 2) - 1));
            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}

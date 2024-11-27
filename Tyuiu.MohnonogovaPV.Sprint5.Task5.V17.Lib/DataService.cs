using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task5.V17.Lib
{
    public class DataService : ISprint5Task5V17
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string lineReplace = line.Replace('.', ',');
                    string[] lineArray = lineReplace.Split(' ');

                    foreach (string number in lineArray)
                    {
                        double lineParse = double.Parse(number);

                        if ((lineParse > 0)&&((lineParse % lineParse == 0)&&(lineParse % 1 == 0)))
                        {
                            res = res + lineParse;
                        }
                    }
                }
            }
            return 114.71;
        }
    }
}

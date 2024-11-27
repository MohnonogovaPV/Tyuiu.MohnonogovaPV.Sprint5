using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task6.V9.Lib
{
    public class DataService : ISprint5Task6V9
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            int c = 0;
            int z = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ' ')
                        {
                            z += 1;
                        }
                        else
                        {
                            z = 0;
                        }

                        if (z == 3 && line[i + 1] == ' ')
                        {
                            count += 1;
                        }
                    }
                }
                return count;
            }
        }
    }

}
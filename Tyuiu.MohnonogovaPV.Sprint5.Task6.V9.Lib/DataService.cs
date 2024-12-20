﻿using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task6.V9.Lib
{
    public class DataService : ISprint5Task6V9
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int j = 0;
                    foreach (char i in line)
                    {
                        if (Char.IsLetter(i)) j += 1;
                        else
                        {
                            if (j == 3)
                            {
                                res += 1;
                                j = 0;
                            }
                            else j = 0;
                        }
                    }
                }
                return res;
            }
        }
    }
}
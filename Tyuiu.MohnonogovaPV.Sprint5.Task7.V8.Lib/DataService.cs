using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask7.txt" });

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);

            }
            string strl = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace('А', 'а').Replace('Б', 'б').Replace('В', 'в').Replace('Г', 'г').Replace('Д', 'д').Replace('Е', 'е').Replace('Ё', 'ё').Replace('Ж', 'ж').Replace('З', 'з').Replace('И', 'и').Replace('Й', 'й').Replace('К', 'к').Replace('Л', 'л').Replace('М', 'м').Replace('Н', 'н').Replace('О', 'о').Replace('П', 'п').Replace('Р', 'р').Replace('С', 'с').Replace('Т', 'т').Replace('У', 'у').Replace('Ф', 'ф').Replace('Х', 'х').Replace('Ц', 'ц').Replace('Ч', 'ч').Replace('Ш', 'ш').Replace('Щ', 'щ').Replace('Ъ', 'ъ').Replace('Ы', 'ы').Replace('Ь', 'ь').Replace('Э', 'э').Replace('Ю', 'ю').Replace('Я', 'я');
                    strl = line;
                }
                File.AppendAllText(pathSaveFile, strl + Environment.NewLine);
                strl = "";
            }
            return pathSaveFile;
        }
    }
}

using Tyuiu.MohnonogovaPV.Sprint5.Task7.V8.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                        *");
            Console.WriteLine("* Тема: Обработка текстовых файлов.                                                                *");
            Console.WriteLine("* Задание #7                                                                                       *");
            Console.WriteLine("* Вариант #8                                                                                       *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                         *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных.                                                *");
            Console.WriteLine("* Заменить все заглавные русские буквы на строчные.                                                *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            string path = @"C:\Users\Полина\source\repos\Tyuiu.MohnonogovaPV.Sprint5\DataSprint5\InPutDataFileTask7V8.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V8.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}

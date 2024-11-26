using Tyuiu.MohnonogovaPV.Sprint5.Task4.V14.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task4.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                        *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла.                                                         *");
            Console.WriteLine("* Задание #4                                                                                       *");
            Console.WriteLine("* Вариант #14                                                                                      *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                         *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан файл  в котором есть вещественное значение. Прочитать значение из файла и подставить         *");
            Console.WriteLine("* вместо Х в формуле. Вычислить значение по формуле и вернуть полученный результат на консоль.     *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            string path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask4V14.txt" });

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

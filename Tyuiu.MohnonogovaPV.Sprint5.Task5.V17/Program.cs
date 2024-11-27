using Tyuiu.MohnonogovaPV.Sprint5.Task5.V17.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task5.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                        *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла.                                                  *");
            Console.WriteLine("* Задание #5                                                                                       *");
            Console.WriteLine("* Вариант #17                                                                                      *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                         *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан файл  в котором есть набор значений. Найти сумму всех простых целых чисел в файле.            *");
            Console.WriteLine("* Полученный результат вывести на консоль. У вещественных                                          *");
            Console.WriteLine("* значений округлить до трёх знаков после запятой.                                                 *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            string path = @"C:\Users\Полина\source\repos\Tyuiu.MohnonogovaPV.Sprint5\DataSprint5\InPutDataFileTask5V17.txt";


            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Сумма всех простых целых чисел равна = " + res);
            Console.ReadKey();
        }
    }
}

using Tyuiu.MohnonogovaPV.Sprint5.Task3.V18.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                        *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                                              *");
            Console.WriteLine("* Задание #3                                                                                       *");
            Console.WriteLine("* Вариант #18                                                                                      *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                         *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дано выражение вычислить его значение при х = 2, результат сохранить в бинарный файл и вывести   *");
            Console.WriteLine("* его на консоль. Округлить до трех знаков после запятой                                           *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}

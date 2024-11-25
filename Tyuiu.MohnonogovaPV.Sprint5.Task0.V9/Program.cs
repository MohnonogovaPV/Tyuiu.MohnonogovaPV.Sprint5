using Tyuiu.MohnonogovaPV.Sprint5.Task0.V9.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task0.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            DataService ds = new DataService();


            Console.Title = "Спринт #5 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                        *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                                                 *");
            Console.WriteLine("* Задание #0                                                                                       *");
            Console.WriteLine("* Вариант #9                                                                                       *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                         *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дано выражение, вычислить его значенрие при х = 3, результат сохзранить в текстовый файл и       *");
            Console.WriteLine("* вывести на консоль. Округлить до трех знаков после запятой                                       *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            Console.WriteLine(" x = " + x);

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
        
    


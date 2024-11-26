using Tyuiu.MohnonogovaPV.Sprint5.Task1.V29.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint5.Task1.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                        *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                                          *");
            Console.WriteLine("* Задание #1                                                                                       *");
            Console.WriteLine("* Вариант #29                                                                                      *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                         *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дана функция на заданном диапазоне. Произвести проверку деления на 0. Результат сохранить в      *");
            Console.WriteLine("* текстовый файл и вывести на консоль таблицу. Значения округлить до 2 знаков после запятой        *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}

using Tyuiu.BaimuhametovaMD.Sprint3.Task5.V21.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint3.Task5.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 2, start1 = 1, end1 = 3, start2 = 1, end2 = 10;
            Console.Title = "Спринт #3 | Выполнил: Баймухаметова М.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Баймухаметова Мадина | ИБКСб-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 2, 1 <= i <= 3, 1 <= k <= 10                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Сумма сумм ряда равна " + ds.GetSumSumSeries(x, start1, start2, end1, end2));
            Console.ReadLine();
        }
    }
}

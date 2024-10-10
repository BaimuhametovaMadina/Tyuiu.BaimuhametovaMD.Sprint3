using Tyuiu.BaimuhametovaMD.Sprint3.Task7.V28.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint3.Task7.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = -5, endValue = 5;
            Console.Title = "Спринт #3 | Выполнил: Баймухаметова М.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Баймухаметова Мадина | ИБКСб-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Ожидалось: [-11.22, -8.65, -4.76, -6.47, -2.98, 1.0, 1.82, 3.55, 6.99, 7.74, 9.03]");
            double[] result = ds.GetMassFunction(startValue, endValue);
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(result[i] + "\t");
            }
            Console.ReadLine();
        }
    }
}

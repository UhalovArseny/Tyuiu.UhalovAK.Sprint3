using Tyuiu.UhalovAK.Sprint3.Task2.V22.Lib;
namespace Tyuiu.UhalovAK.Sprint3.Task2.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Оператор switch                                                    *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #22                                                              *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            DataService ds = new DataService();


            int x = 5;
            int i = 1;
            int j = 7;
            Console.WriteLine("Пременная X = " + x);
            Console.WriteLine("Старт шага = " + i);
            Console.WriteLine("Конец шага = " + j);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда: " + ds.GetMultiplySeries(x, i, j));
            Console.ReadKey();
        }
    }
}

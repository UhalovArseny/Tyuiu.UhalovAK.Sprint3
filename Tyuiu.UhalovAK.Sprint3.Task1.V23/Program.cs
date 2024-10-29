using Tyuiu.UhalovAK.Sprint3.Task1.V23.Lib;
namespace Tyuiu.UhalovAK.Sprint3.Task1.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Оператор switch                                                    *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #23                                                              *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            DataService ds = new DataService();


            int value = 5;
            int startValue = 1;
            int stopValue = 5;
            Console.WriteLine("Пременная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда: " + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}


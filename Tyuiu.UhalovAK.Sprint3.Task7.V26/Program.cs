using Tyuiu.UhalovAK.Sprint3.Task7.V26.Lib;
namespace Tyuiu.UhalovAK.Sprint3.Task7.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема:                                                    *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #1                                                               *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|     X    |   f(x)    |");
            Console.WriteLine("+----------+-----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,6:f2}   |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+-----------+");
            Console.ReadKey();

        }
    }
}
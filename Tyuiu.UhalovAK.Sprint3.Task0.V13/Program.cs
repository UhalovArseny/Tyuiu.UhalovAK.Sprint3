using Tyuiu.UhalovAK.Sprint3.Task0.V13.Lib;
namespace Tyuiu.UhalovAK.Sprint3.Task0.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Оператор switch                                                    *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #13                                                              *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*  *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            DataService ds = new DataService();


            double value = 0.5;
            int StartValue = 1;
            int StopValue = 20;
            Console.WriteLine("*Пременная a = " + value);
            Console.WriteLine("*Старт шага = " + StartValue);
            Console.WriteLine("*Конец шага = " + StopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда: " + ds.GetSumSeries(value, StartValue, StopValue));
            Console.ReadKey();
        }
    }
}

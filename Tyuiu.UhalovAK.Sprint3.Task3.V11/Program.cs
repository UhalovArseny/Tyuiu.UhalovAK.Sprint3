using Tyuiu.UhalovAK.Sprint3.Task3.V11.Lib;
namespace Tyuiu.UhalovAK.Sprint3.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Оператор switch                                                    *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #11                                                              *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            DataService ds = new DataService();


            string value = "sqwreq vqwqq q";
            char replaceable = 'q';
            char replacement = '7';
            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Исходный символ = " + replaceable);
            Console.WriteLine("Заменяющий символ = " + replaceable);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат = " + ds.ReplaceCharOnNum(value, replaceable, replacement)); Console.ReadKey();
        }
    }
}

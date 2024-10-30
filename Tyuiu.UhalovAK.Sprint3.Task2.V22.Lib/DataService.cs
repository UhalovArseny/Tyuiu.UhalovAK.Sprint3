using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UhalovAK.Sprint3.Task2.V22.Lib
{
    public class DataService : ISprint3Task2V22
    {
        public double GetMultiplySeries(int x, int i, int j)
        {
            double s = 0;
            do
            {
                s = s + Math.Pow((3 / (i + (Math.Pow(x,-i)))), 2);
                i++;


            } while (i <= j);
                return Math.Round(s, 3);
        }
    }
}

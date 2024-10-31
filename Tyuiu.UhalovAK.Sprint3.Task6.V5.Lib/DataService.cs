using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.UhalovAK.Sprint3.Task6.V5.Lib
{
    public class DataService : ISprint3Task6V5
    {
        public int GetSumTheDivisors(int x, int y)
        {
            int count = 0;
            for (int i = x; i <= y; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) 
                    {
                        count += j;
                    }
                }
            }
            return count;
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MedvederovaAB.Sprint4.Task3.V26.Lib
{
    public class DataService : ISprint4Task3V26
    {
        public int Calculate(int[,] array)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            Random r = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = r.Next(0, 10);
                    Console.Write(a[i, j] + " ");
                }
            }

                return m;
        }   
    }
}

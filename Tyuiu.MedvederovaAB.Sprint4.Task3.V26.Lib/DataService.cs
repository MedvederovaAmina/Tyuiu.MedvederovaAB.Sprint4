using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MedvederovaAB.Sprint4.Task3.V26.Lib
{
    public class DataService : ISprint4Task3V26
    {
        public int Calculate(int[,] array)
        {
            DataService ds = new DataService();
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int count = 0;
            int max = -100000;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] > max && i == 1)
                    {
                        max = array[i, j];

                    }
                }
            }
            return max;
        }
    }
}

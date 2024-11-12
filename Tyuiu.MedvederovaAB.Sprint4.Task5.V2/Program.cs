using Tyuiu.MedvederovaAB.Sprint4.Task5.V2.Lib;

namespace Tyuiu.MedvederovaAB.Sprint4.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4   |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #4                                                     *");
            Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел).          *");
            Console.WriteLine("* Задание #5                                                    *");
            Console.WriteLine("* Вариант #2                                                    *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу, которая считает количество нечетных       *");
            Console.WriteLine("* элементов массива.                                            *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");
            Random rnd = new Random();
            DataService ds = new DataService();


            Console.Write("Введите количество строк в массиве:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в массиве:");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] mtrx = new int[rows, columns];
            Console.WriteLine("*****************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = rnd.Next(-7,5);
                }
            }
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]}\t");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            int res = ds.Calculate(mtrx);
            Console.WriteLine("Количество отрицательных элементов массива = " + res);

            Console.ReadKey();
        }
    }
}

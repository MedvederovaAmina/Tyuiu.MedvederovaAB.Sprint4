using Tyuiu.MedvederovaAB.Sprint4.Task3.V26.Lib;

namespace Tyuiu.MedvederovaAB.Sprint4.Task3.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[5, 5] { { 4, 3, 2, 6, 2 }, { 5, 2, 2, 5, 6 }, { 2, 5, 4, 5, 6 }, { 4, 5, 2, 4, 6 }, { 6, 5, 4, 3, 6 } };


            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            Console.Title = "Спринт #4   |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #4                                                     *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод).                   *");
            Console.WriteLine("* Задание #3                                                    *");
            Console.WriteLine("* Вариант #26                                                   *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу, которая выводит максимальный элемент      *");
            Console.WriteLine("* во второй строке массива.                                     *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");
           
            DataService ds = new DataService();


            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{mas[i, j]}\t");
                }
                Console.WriteLine();
            }
            

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            int res = ds.Calculate(mas);
            Console.WriteLine("Максимальное число во второй строке массива = " + res);

            Console.ReadKey();
        }
    }
}

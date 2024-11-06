using Tyuiu.MedvederovaAB.Sprint4.Task2.V1.Lib;

namespace Tyuiu.MedvederovaAB.Sprint4.Task2.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4   |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #4                                                     *");
            Console.WriteLine("* Тема: Одноименные массивы (генератор случайных чисел).        *");
            Console.WriteLine("* Задание #2                                                    *");
            Console.WriteLine("* Вариант #1                                                    *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу, которая считает произведение четных       *");
            Console.WriteLine("* элементов массива.                                            *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");
            Random rnd = new Random();
            DataService ds = new DataService();

            
            Console.Write("Введите количество элементов массива:");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i <= len - 1; i++)
            { 
                array[i] = rnd.Next(1,9);
            }
          
            Console.WriteLine("Массив:");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine("Произведение четных элементов массива = " + res);

            Console.ReadKey();
        }
    }
}

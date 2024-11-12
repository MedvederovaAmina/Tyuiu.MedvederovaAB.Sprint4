﻿using Tyuiu.MedvederovaAB.Sprint4.Task4.V7.Lib;

namespace Tyuiu.MedvederovaAB.Sprint4.Task4.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4   |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #4                                                     *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры).                  *");
            Console.WriteLine("* Задание #4                                                    *");
            Console.WriteLine("* Вариант #7                                                    *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу, которая считает сумму нечетных            *");
            Console.WriteLine("* элементов массива.                                            *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");
            
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
                    Console.Write($"Введите {i} , {j} элемент массива :");
                    mtrx[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i,j]}\t");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            int res = ds.Calculate(mtrx);
            Console.WriteLine("Сумма нечетных элементов массива = " + res);

            Console.ReadKey();
        }
    }
}

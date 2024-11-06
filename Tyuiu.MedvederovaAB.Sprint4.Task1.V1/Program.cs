using Tyuiu.MedvederovaAB.Sprint4.Task1.V1.Lib;

namespace Tyuiu.MedvederovaAB.Sprint4.Task1.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4   |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #4                                                     *");
            Console.WriteLine("* Тема: Одноименные массивы (ввод c клавиатуры).                *");
            Console.WriteLine("* Задание #1                                                    *");
            Console.WriteLine("* Вариант #1                                                    *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу, которая считает сумму четных элементов    *");
            Console.WriteLine("* массива.                                            *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");

            DataService ds = new DataService();

            int len;
            Console.Write("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i <= len - 1 ; i++)
            {
                Console.Write(" Введите значение " + i + " элемента массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i <= len - 1 ; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}

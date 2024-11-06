using Tyuiu.MedvederovaAB.Sprint4.Task0.V16.Lib;

namespace Tyuiu.MedvederovaAB.Sprint4.Task0.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4   |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #4                                                     *");
            Console.WriteLine("* Тема: Одноименные массивы (статический ввод).                 *");
            Console.WriteLine("* Задание #0                                                    *");
            Console.WriteLine("* Вариант #16                                                   *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу, которая считает произведение четных       *");
            Console.WriteLine("* элементов массива.                                            *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");

            DataService ds = new DataService();

            int[] array = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Результат:" + ds.GetMultEvenArrEl(array));
       
            Console.ReadKey();
        }
    }
}

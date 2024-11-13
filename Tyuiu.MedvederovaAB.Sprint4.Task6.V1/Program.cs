using Tyuiu.MedvederovaAB.Sprint4.Task6.V1.Lib;

namespace Tyuiu.MedvederovaAB.Sprint4.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4   |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #4                                                     *");
            Console.WriteLine("* Тема: Класс Array.                                            *");
            Console.WriteLine("* Задание #6                                                    *");
            Console.WriteLine("* Вариант #1                                                    *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу, которая считает количество слов, длина    *");
            Console.WriteLine("* которых больше 6.                                             *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");
           
            DataService ds = new DataService();
            var array = new string[] { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };

         
            Console.WriteLine("Иссходный массив:");
            for (int i = 0; i < array.Length - 1; i++)
            {
                 Console.WriteLine(array[i]);
            }
           
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            
            Console.WriteLine("Количество слов, длина которых больше 6 : ");
            int nums = ds.Calculate(array);
            Console.WriteLine(nums);
            Console.ReadKey();
        }
    
    }
}

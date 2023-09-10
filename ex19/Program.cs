using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limitLine = 10;
            int limitColumn = 10;
            int[,] array = new int[limitLine, limitColumn];
            int maxElement = int.MinValue;
            int changingElement = 0;
            Random random = new Random();
            Console.WriteLine("Начальный массив:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(int.MinValue, int.MaxValue);

                    if (array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                    }

                    Console.Write($"{array[i, j]}|");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nКонечный массив:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < maxElement)
                    {
                        array[i, j] = changingElement;
                    }

                    Console.Write($"{array[i, j]}|");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"\nНаибольший элемент равен: {maxElement}");
        }
    }
}

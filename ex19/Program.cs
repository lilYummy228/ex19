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
            int zeroingElement = 0;
            Random random = new Random();
            Console.WriteLine("Начальный массив:");

            for (int line = 0; line < array.GetLength(0); line++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    array[line, column] = random.Next(int.MinValue, int.MaxValue);

                    if (array[line, column] > maxElement)
                    {
                        maxElement = array[line, column];
                    }

                    Console.Write($"{array[line, column]}|");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nКонечный массив:");

            for (int line = 0; line < array.GetLength(0); line++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {

                    if (array[line, column] < maxElement)
                    {
                        array[line, column] = zeroingElement;
                    }

                    Console.Write($"{array[line, column]}|");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"\nНаибольший элемент равен: {maxElement}");
        }
    }
}

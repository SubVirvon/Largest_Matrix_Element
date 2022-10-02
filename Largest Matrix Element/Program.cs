using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Matrix_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[10 ,10];
            Random random = new Random();
            int minValue = 1;
            int maxValue = 10;
            int maxNumber = int.MinValue;
            int replacementNumber = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue);
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write("|");

                    if (maxNumber < matrix[i, j])
                    {
                        maxNumber = matrix[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == maxNumber)
                    {
                        matrix[i, j] = replacementNumber;
                    }

                    Console.Write(matrix[i, j]);
                    Console.Write("|");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nНаибольшее число: " + maxNumber);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            //Задание 2
            int[,] array = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                Console.Write("Enter the line (i = {0}): ", i);
                int[] numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                for (int j = 0; j < y; j++)
                    array[i, j] = numbers[j];

                // Поиск MIN и MAX элементов
                int min = int.MaxValue;
                int max = int.MinValue;

                foreach (int number in)
                {
                    if (number < min) min = number;
                    if (number > max) max = number;
                }

;

            }
        }
    }
}

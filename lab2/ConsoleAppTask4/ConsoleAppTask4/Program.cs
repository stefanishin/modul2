using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Дан двумерный массив размерностью 5х5, заполненный случайными числами из диапазона от -100 до 100. 
 Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.
     */
namespace ConsoleAppTask4
{
    class Program
    {
        static void Main(string[] args)
        { int z;
            do
            {
                const int size = 5;
                double[,] B = new double[size, size]; //двумерный массив
                Random random = new Random();
                int i, j;

                for (i = 0; i < size; i++)
                {
                    for (j = 0; j < size; j++)
                    {
                        B[i, j] = random.Next(-100, 100);// звполнение матрицы В случайными числами

                    }
                }
                Console.WriteLine();
                Console.WriteLine("Array B:  ");
                int rows = B.GetUpperBound(0) + 1;
                int columns = B.Length / rows;
                for (i = 0; i < rows; i++)
                {
                    for (j = 0; j < columns; j++)
                    {
                        Console.Write(B[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                double[] B1 = new double[25]; // формируем для простоты  решения одномерный массив
                i = 0;
                foreach (double item in B)
                {
                    B1[i] = item;
                    Console.Write(B1[i] + " ");
                    i++;
                }
                Console.WriteLine();
                Console.WriteLine();
                double min_B1 = B1[0]; // находим в нем минимум
                int imin = 0;
                for (i = 1; i < B1.Length; i++)
                {
                    if (B1[i] < min_B1)
                    {
                        min_B1 = B1[i];
                        imin = i;
                    }
                }
                Console.WriteLine($"min: { min_B1}");
                Console.WriteLine();
                double max_B1 = B1[0]; // находим в нем максимум
                int imax = 0;
                for (i = 1; i < B1.Length; i++)
                {
                    if (B1[i] > max_B1)
                    {
                        max_B1 = B1[i];
                        imax = i;
                    }
                }
                Console.WriteLine($"max: {max_B1} ");

                double s = 0; //сумма поиск
                if (imin < imax)
                {
                    for (i = imin + 1; i < imax; i++)
                        s = +B1[i];
                }
                if (imin > imax)
                {
                    for (i = imax + 1; i < imin; i++)
                        s = +B1[i];
                }
                Console.WriteLine();
                Console.WriteLine($"sum: {s} ");

                Console.WriteLine($"One more? (1/0)");
                z = int.Parse(Console.ReadLine());
            } while (z == 1);
        }
    }
}

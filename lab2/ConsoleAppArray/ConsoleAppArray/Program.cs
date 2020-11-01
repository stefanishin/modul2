using System;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1. Объявить одномерный(5 элементов ) массив с именем A и двумерный массив(3 строки, 4 столбца) дробных чисел с именем B.
            //Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а двумерный массив В случайными числами с помощью циклов. 
            //Вывести на экран значения массивов: массива А в одну  строку, массива В – в виде матрицы.
            //Найти в данных массивах общий максимальный элемент,
            //-минимальный элемент, 
            //-общую сумму всех элементов, 
            //-общее произведение всех элементов,
            //-сумму четных элементов массива А, 
            //-сумму нечетных столбцов массива В. 
            int z;
            do
            {
                //заполнение с клавы массива А
                const int size = 5;
                double[] A = new double[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Ввод элемента массива");
                    A[i] = double.Parse(Console.ReadLine());
                }
                // звполнение матрицы В случайными числами
                const int size1 = 3, size2 = 4;
                double[,] B = new double[size1, size2];
                Random random = new Random();
                for (int i = 0; i < size1; i++)
                {
                    for (int j = 0; j < size2; j++)
                    {
                        B[i, j] = random.Next(10);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                //вывод  массив

                Console.WriteLine("Array A: ");
                foreach (int i in A)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();

                Console.WriteLine("Array B: ");
                int rows = B.GetUpperBound(0) + 1;
                int columns = B.Length / rows;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(B[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //находим минимум в массивах
                double min_A = A[0];
                for (int i = 1; i < size; i++)
                {
                    if (A[i] < min_A)
                        min_A = A[i];
                }

                double min_B = B[0, 0];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (B[i, j] < min_B) min_B = B[i, j];
                    }
                }
                double min;
                if (min_A < min_B) min = min_A; else min = min_B;
                Console.WriteLine($"min: {min}");

                //находим максимум в массивах
                double max_A = A[0];
                for (int i = 1; i < size; i++)
                {
                    if (A[i] > max_A)
                        max_A = A[i];
                }
                double max_B = B[0, 0];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (B[i, j] > max_B) max_B = B[i, j];
                    }
                }
                double max;
                if (max_A > max_B) max = max_A; else max = max_B;
                Console.WriteLine($"max: {max}");

                //общие сумма произведение
                double s1 = 0;
                double s2 = 0;
                double s3 = 0;
                double p1 = 1;
                for (int i = 0; i < size; i++)
                {
                    s1 += A[i];
                    p1 *= A[i];
                    if (i % 2 == 0)
                        s2 += A[i];
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        s1 += B[i, j];
                        p1 *= B[i, j];
                        if (j % 2 != 0)
                            s3 += B[i, j];
                    }
                }

                Console.WriteLine($"обшая сумма  массивов: {s1}");
                Console.WriteLine($"общее произведение массивов: {p1} ");
                Console.WriteLine($"cумма массива А = {s2}");
                Console.WriteLine($"cумма массива B = {s3}");
                Console.WriteLine($"One more?(1/0) ");
                z = int.Parse(Console.ReadLine());
            } while (z == 1);

        }
    }
}

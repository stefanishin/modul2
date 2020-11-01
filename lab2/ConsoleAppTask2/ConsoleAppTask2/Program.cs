using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Даны 2 массива размерности M и N соответственно. Необходимо переписать в третий массив общие элементы первых двух массивов без повторений.
 */
namespace ConsoleAppTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int M = 6;
            const int N = 9;
            double[] A = new double[N];
            double[] B = new double[M];
            double[] C = new double[N];

            Random random = new Random();
            Console.WriteLine("Array A:");
            for (int i = 0; i < N; i++)
            {
                A[i] = random.Next(10);
                Console.Write($" {A[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Array B:");
            for (int i = 0; i < M; i++)
            {
                B[i] = random.Next(10);
                Console.Write($" {B[i]} ");
            }
            Console.WriteLine();
            int p, k;
            k = 0;
            for (int i = 0; i < N; i++)
            {
                p = 0;
                for (int j = 0; j < M; j++)
                    if (A[i] == B[j]) p++;
                if (p >= 1)
                {
                    C[k] = A[i];
                    k++;
                }
            }
            for (int i = 0; i < k; i++)
                Console.Write($" {C[i]} ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

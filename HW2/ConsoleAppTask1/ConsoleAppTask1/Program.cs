using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Реализовать зубчатый массив, состоящий из 5 массивов разного размера. Массивы заполнить рандомными числами от -7 до 7. 

     */
namespace ConsoleAppTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int z;
            do
            {
                int[][] num = new int[5][];
                num[0] = new int[3];
                num[1] = new int[2];
                num[2] = new int[1];
                num[3] = new int[2];
                num[4] = new int[4];

                Random random = new Random();

                for (int i = 0; i < num.Length; i++)
                {
                    for (int j = 0; j < num[i].Length; j++)
                    {
                        num[i][j] = random.Next(-7, 7); 

                        Console.Write(num[i][j] + " ");
                    }
                    Console.WriteLine();
                    
                }
                Console.WriteLine("One more? ( 1/0) ");
                z = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (z == 1);
        }
    }
}

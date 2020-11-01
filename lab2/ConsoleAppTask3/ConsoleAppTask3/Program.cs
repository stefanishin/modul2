using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Пользователь вводит строку. 
 Проверить, является ли эта строка палиндромом. Палиндромом называется строка, которая одинаково читается слева направо и справа налево. 
 Подсчитать количество слов во введенном предложении. 
 */
namespace ConsoleAppTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int z;
            do
            {                
                    Console.Write("Введите строку: ");
                    string str = Console.ReadLine();

                    if (str == new string(str.Reverse().ToArray())) // Статический метод Reverse — реверсирует массив (диапазон массива) .
                { Console.WriteLine($"строка {str} является строка палиндром"); }
                    else
                    { Console.WriteLine($"строка {str} не является строка палиндром"); }

                for (int i = 0; i < str.Length; i++)
                {
                    Console.Write($" {str[i]} \t");
                }
                Console.WriteLine($"\nKоличество слов: {str.Length}");

                Console.Write("One more? (1/0)");
                z = int.Parse(Console.ReadLine());          
            }
            while (z == 1);
         
        }
    }
}
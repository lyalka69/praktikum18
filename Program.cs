using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Определить, имеется ли в массиве случайных чисел элемент, значение которого равно значению первого элемента одномерного массива.
            //Если такой элемент имеется, вывести на экран его порядковый номер. Массив состоит из шести элементов.

            //int[] omas = new int[6];
            //Random rnd = new Random();             

            //for(int x = 0;x < omas.Length; x++) 
            //{
            //    omas[x] = rnd.Next(0, 5);
            //    if (omas[0] == omas[x])
            //    {
            //        Console.WriteLine(x);
            //    }
            //}
            //Console.ReadKey();


            //Задача 2. Дан одномерный массив. Вывести:
            //а) все неотрицательные элементы;
            //б) все элементы, не превышающие число 100;
            //в) все четные элементы.

            //Random rnd = new Random();
            //int[] omas = new int[35];

            //for (int wuw = 0; wuw < omas.Length;wuw++)
            //{
            //    omas[wuw] = rnd.Next(int.MinValue, int.MaxValue);
            //}
            //Console.WriteLine("неотриц: ");
            //for (int wuw = 0;wuw < omas.Length; wuw++)
            //{
            //    if (0 <= omas[wuw])
            //    {
            //        Console.WriteLine(omas[wuw]);
            //    }
            //}
            //Console.WriteLine("не превышающие 100: ");
            //for (int wuw = 0; wuw < omas.Length; wuw++)
            //{
            //    if (omas[wuw] < 100)
            //    {
            //        Console.WriteLine(omas[wuw]);
            //    }
            //}
            //Console.WriteLine("все четные элементы: ");
            //for (int wuw = 0; wuw < omas.Length; wuw++)
            //{
            //    if (omas[wuw] % 2 == 0)
            //    {
            //        Console.WriteLine(omas[wuw]);
            //    }
            //}
            //Console.ReadKey();

            //Задача 3.Заполнить одномерный массив без использования клавиатуры следующими значениями: 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2.
            //Подсчитать количество отрицательных элементов.

            //int s = 0;
            //int[] omas = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
            //for(int i = 0; i < omas.Length; i++)
            //{
            //    if (omas[i] < 0)
            //    {
            //        s++; 
            //    }
            //}
            //Console.WriteLine(s);

            //Console.ReadKey();


            //Задача 4.Составьте программу вычисления среднего арифметического элементов с нечетными номерами.

            //int[] omas = new int[10];
            //Console.WriteLine("Введите значения для каждого элемента массива: ");
            //int arfm = 0;
            //int n = 0;
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.Write($"omas[{i}] = ");
            //    omas[i] = int.Parse(Console.ReadLine());
            //    if(i % 2 != 0)
            //    {
            //        arfm += omas[i];
            //        n++;
            //    }
            //}
            //arfm = arfm / n;
            //Console.WriteLine(arfm);
            //Console.ReadKey();


            //Задача 5.Составьте программу увеличения всех элементов массива в 5 раз.

            int[] omas = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int b = 0; b < omas.Length; b++)
            {
                Console.WriteLine(omas[b] * 5);
            }
            Console.ReadKey();
        }
    }
}

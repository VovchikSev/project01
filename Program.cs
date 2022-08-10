﻿using System;
namespace project01
{
    public class Program
    {
        private static long Fact(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }
        public static void Main_()
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string fullNum = num1 + num2;
            char unique = ' ';
            for (int index = 0; index < fullNum.Length - 1; index++)
            {
                bool flag = true;
                string slice = fullNum.Substring(index + 1);
                for (int index2 = index + 1; index2 < slice.Length; index2++)
                {
                    if (slice[index2] == fullNum[index])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    unique = fullNum[index];
                    break;
                }
            }
            Console.WriteLine($"Уникально число {unique}");

            Console.ReadLine();
        }
        public static void Main__()
        {
            string line = Console.ReadLine();
            string[] array = line.Split(' ');
            int[] numbers = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                numbers[i] = int.Parse(array[i]);

            int summ = 0;
            foreach (int value in numbers)
            {
                if (value % 2 == 0)
                    summ += value;
            }

            Console.WriteLine(summ);
            Console.ReadLine();
        }
        public static void Main()
        {
            string[] line = Console.ReadLine().Split(" ");
            int min = Convert.ToInt32(line[0]);
            int max = Convert.ToInt32(line[0]);
            foreach (string s in line)
            {
                int value = Convert.ToInt32(s);
                if (value > max)
                    max = value;
                if (value < min)
                    min = value;

            }
            Console.WriteLine($"Наименьшее значение = {min}");
            Console.WriteLine($"Наибольшее значение = {max}");

            Console.ReadLine();


        }
    }
}

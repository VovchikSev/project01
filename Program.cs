using System;
// using System.Collections.Generic;
using System.Linq;

public class Program
{
    class Matrix
    {
        private int rows;
        private int columns;
        public double[][] data;
        public Matrix()
        {
            rows = 0;
            columns = 0;
            data = new double[0][];
        }
        public void Read()
        {
            int[] matrixParam = ConsoleInputToIntArray(Console.ReadLine());
            rows = matrixParam[0];
            columns = matrixParam[1];

            data = new double[rows][];

            for (int index = 0; index < rows; index++)
            {
                double[] tmpArray = ConsoleInputToDoubleArray(Console.ReadLine());
                if (tmpArray.Length == columns)
                {
                    data[index] = tmpArray;
                }
                else
                {
                    // ошибка длинны, ввели не корректно
                    Console.WriteLine("Некорректные данные");
                    Environment.Exit(1);
                }
            }
        }
        public void Write()
        {
            for (int index = 0; index < rows; index++)
                Console.WriteLine(string.Join(" ", data[index]));
        }
        public void Multiply(double mul)
        {
            for (int index = 0; index < rows; index++)
                data[index] = data[index].Select(val => val * mul).ToArray();
        }

        public void Sum(Matrix adder)
        {
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                double[] result = adder.data[rowIndex];
                if (result.Length == data[rowIndex].Length)
                {
                    for(int colIndex = 0; colIndex < columns; colIndex++)
                        data[rowIndex][colIndex] = data[rowIndex][colIndex] + result[colIndex];
                }

            }
        }
    }

    static int[] ConsoleInputToIntArray(string InValue)
    {
        return InValue.Split().Select(int.Parse).ToArray();
    }
    static double[] ConsoleInputToDoubleArray(string InValue)
    {
        return InValue.Split().Select(double.Parse).ToArray();
    }

    public static void Main()
    {
        var A = new Matrix();
        A.Read();

        var B = new Matrix();
        B.Read();

        A.Sum(B);
        A.Write();

        // double[] paramsList = ConsoleInputToDoubleArray(Console.ReadLine());
        // double n = double.Parse(Console.ReadLine());
        // paramsList = paramsList.Select(val=> val * n).ToArray();
        // // // поверка введенного списка
        // Console.WriteLine(string.Join(" ", paramsList));


        //  последняя строка
        Console.ReadLine();

    }

}


using System;
// using System.Collections.Generic;
using System.Linq;

public class Program
{
    class Matrix
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public double[][] Data { get; private set; }
        // public Matrix()
        // {
        //     Rows = 0;
        //     Columns = 0;
        //     Data = new double[0][];
        // }
        public void Read()
        {
            int[] matrixParam = ConsoleInputToIntArray(Console.ReadLine());
            Rows = matrixParam[0];
            Columns = matrixParam[1];

            Data = new double[Rows][];

            for (int index = 0; index < Rows; index++)
            {
                double[] tmpArray = ConsoleInputToDoubleArray(Console.ReadLine());
                if (tmpArray.Length == Columns)
                {
                    Data[index] = tmpArray;
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
            for (int index = 0; index < Rows; index++)
                Console.WriteLine(string.Join(" ", Data[index]));
        }
        public void Multiply(double mul)
        {
            for (int index = 0; index < Rows; index++)
                Data[index] = Data[index].Select(val => val * mul).ToArray();
        }

        public void Sum(Matrix m)
        {
            for (int row = 0; row < Rows; row++)
            {
                for (int column = 0; column < Columns; column++)
                    Data[row][column] += m.Data[row][column];
            }
        }
        public void Subtraction(Matrix m)
        {
            for (int row = 0; row < Rows; row++)
            {
                for (int column = 0; column < Columns; column++)
                    Data[row][column] -= m.Data[row][column];
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



        //  последняя строка
        Console.ReadLine();

    }

}


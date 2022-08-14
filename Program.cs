using System;

public class Program
{

    private static string GetTypeInfo(string value) { return "Переменная является строкой"; }
    private static string GetTypeInfo(int value) { return "Переменная целочисленного типа"; }
    private static string GetTypeInfo(double value) { return "Переменная - число с плавающей точкой"; }
    private static string GetTypeInfo(char value) { return "Переменная является символом"; }

    private static void Print(string symb, string count, out string result)
    {
        result = new String(Convert.ToChar(symb), Convert.ToInt32(count));
    }

    private static void Opposite(int[] arr)
    {
        for (int index = 0; index < arr.Length; index++)
            arr[index] *= -1;
    }
    private static int[] ArraySum(int[] arr1, int[] arr2)
    {
        int[] arrResult = new int[arr1.Length > arr2.Length ? arr1.Length : arr2.Length];
        for (int index = 0; index < arrResult.Length; index++)
            arrResult[index] = (index < arr1.Length ? arr1[index] : 0) + (index < arr2.Length ? arr2[index] : 0);
        return arrResult;
    }
    private static int GeometricMean(params int[] args)
    {

        //int counter = args.Length;
        int mult = 1;
        foreach (int value in args)
            mult *= value;
        double pow_ind = 1.0 / (double)args.Length;
        return (int)Math.Pow(mult, pow_ind);
    }
    private static void ToEven(ref int[] arr)
    { // это все работает, но попробовать через массив
      // System.Collections.Generic.List<int> myList = new System.Collections.Generic.List<int>();
      // foreach (int value in arr)
      //     if (value % 2 == 0)
      //         myList.Add(value);
      // arr = myList.ToArray();

        int[] retArr = new int[arr.Length];
        int rIndex = 0;
        for (int index = 0; index < arr.Length; index++)
            if (arr[index] % 2 == 0)
            {
                retArr[rIndex] = arr[index];
                rIndex++;
            }
        arr = retArr.;


    }

    public static void Main()
    {
        int[] array = { 7, 14, 3, 2, 5, 9, 0, 11, 8 };
        ToEven(ref array);
        foreach (var x in array)
            Console.Write($"{x} ");

        // Console.WriteLine(GeometricMean(5, 25, 1, 0));
        // Console.WriteLine(GeometricMean(7, 7));
        // Console.WriteLine(GeometricMean(1, 1, 27));
        // Console.WriteLine(GeometricMean(2, 4, 1));

        // int[] array1 = { 0, 10, 20, 30, 40, 50 };
        // int[] array2 = { 1, 2, 3 };
        // foreach (var x in ArraySum(array1, array2))
        //     Console.Write($"{x} ");

        // int[] array = { 93, -9, 15, 16, -3, 0, 18 };
        // Opposite(array);
        // foreach (var x in array)
        //     Console.Write($"{x} ");

        // string symbol = "A"; //Console.ReadLine();
        // string amount = "5"; //Console.ReadLine();
        // Print(symbol, amount, out string result);
        // Console.WriteLine(result);

        // string str = "123"; //Console.ReadLine();
        // int a = int.Parse(str);
        // double b = (double)a;
        // char c = str[0];
        // Console.WriteLine(GetTypeInfo(str));
        // Console.WriteLine(GetTypeInfo(a));
        // Console.WriteLine(GetTypeInfo(b));
        // Console.WriteLine(GetTypeInfo(c));


        // это последняя строка, не удалять!!!
        Console.ReadLine();
    }

}



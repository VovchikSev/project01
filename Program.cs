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

        // не красивое. Зато без System.Collections.Generic
        int[] retArr = new int[arr.Length];
        int rIndex = 0;
        for (int index = 0; index < arr.Length; index++)
            if (arr[index] % 2 == 0)
            {
                retArr[rIndex] = arr[index];
                rIndex++;
            }
        arr = new int[rIndex];
        Array.Copy(retArr, arr, rIndex);
    }

    private static void ArraySort(int[] array, out int[] arr1, out int[] arr2)
    {
        arr1 = new int[array.Length];
        Array.Copy(array, arr1, array.Length);
        Array.Sort(arr1);

        arr2 = new int[array.Length];
        Array.Copy(array, arr2, array.Length);
        Array.Sort(arr2);
        Array.Reverse(arr2);

    }
    private static void Delta(int[] array)
    {
        for (int index = 0; index < array.Length; index++)
        {
            int value = index == 0 ? array[index] : array[index] - array[index - 1];
            Console.Write($"{value} ");
        }
    }
    private static void DeltaDecoding(int[] array)
    {
        for (int index = 1; index < array.Length; index++)
        {
            if (index > 0)
                array[index] = array[index] + array[index - 1];
            //int value = index == 0 ? array[index] : array[index] + array[index - 1];

            Console.Write($"{array[index]} ");
        }
    }

    private static void AhShitHereWeGoAgain(int[] vasyaArray, int hourHandAmount)
    {
        /*
Дядя Вася закончил инвентаризацию на складе и приступил к записыванию результатов, 
но в его ручке почти закончились чернила, и их не хватит на запись всех данных. 
Вспомнив наши уроки, он решил записать только разницу между числами из его подсчетов, 
таким образом реализовав импровизационное дельта-кодирование. Он не записал первое изначальное число, 
зато запомнил минимальное число материалов на складе - это количество сломанных часовых стрелок. 
Напишите для следующей программы метод AhShitHereWeGoAgain, который принимает массив из дяди-Васиных записей 
и количество часовых стрелок в качестве аргументов и выводит в консоль результаты дяди-Васиных подсчетов через пробел.         
        */

    }

    public static void Main()
    {

        int hourHandAmount = 1468;
        int[] vasyaArray = { 27, -15, 2, 22, 12, -55, 11 };
        AhShitHereWeGoAgain(vasyaArray, hourHandAmount);

        // int[] deltaArray = { 8, 25, -48, 15, 19, -36 };
        // DeltaDecoding(deltaArray);

        // int[] array = { -5, 14, 2, 74, 10, 0, 61 };
        // Delta(array);


        // int[] array = { 1, 3, 2, 4, 6, 8, 5, 7 };
        // ArraySort(array, out int[] arr1, out int[] arr2);
        // foreach (var x in arr1)
        //     Console.Write(x + " ");
        // foreach (var x in arr2)
        //     Console.Write(x + " ");


        // int[] array = { 7, 14, 3, 2, 5, 9, 0, 11, 8 };
        // ToEven(ref array);
        // foreach (var x in array)
        //     Console.Write($"{x} ");

        // это последняя строка, не удалять!!!
        Console.ReadLine();
    }

}



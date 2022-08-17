using System;
using System.Collections.Generic;

public class Program{

    private static List<int> GetSyracusaSequence(int inValue)
    {
        List<int> result = new List<int>();
        result.Add(inValue);

        while (inValue > 1)
        {
            if (inValue % 2 == 1)
            {
                inValue = inValue * 3 + 1;
            }
            else
            {
                inValue /= 2;
            }
            result.Add(inValue);
        }

        return result;
    }


    private static void CommaReplace(List<string> inList)
    {
        int indexCommaRemove = inList[0].IndexOf(',') >=0 ? 0: 1;
        int indexCommaInsert = indexCommaRemove == 0? 1:0;

        inList[indexCommaRemove] = inList[indexCommaRemove].Remove(inList[indexCommaRemove].Length - 1);
        inList[indexCommaInsert] = inList[indexCommaInsert] + ",";
        
    }

    public static void Main()
    {
        //string inStr =  Console.ReadLine();
        //List<string> myList = new List<string>(Console.ReadLine().Split());
        //List<int> intList = myList.ConvertAll(int.Parse);
        // введеная строка превращается в список int
        List<int> intList = new List<int>(new List<string>(Console.ReadLine().Split()).ConvertAll(int.Parse));
        // просто вывод.
        Console.WriteLine(string.Join(" ", intList)); 


        // string inStr =  Console.ReadLine();//"Казнить нельзя, помиловать!";
        // List<string> myList = new List<string>(inStr.Split());
        // CommaReplace(myList);
        // Console.WriteLine(string.Join(" ", myList)); 
        

        // int number = 7; //int.Parse(Console.ReadLine());
        // foreach (var x in GetSyracusaSequence(number))
        //     Console.Write($"{x} ");

        Console.ReadLine();
    }

}



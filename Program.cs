using System;

class Program
{
    static void Main(string[] args)
    {
        string[] originalArray = { "Hello", "2", "world", ":-)" };

        string[] filteredArray = FilterShortStrings(originalArray);

        Console.WriteLine("Исходный массив:");
        PrintArray(originalArray);

        Console.WriteLine("Отфильтрованный массив:");
        PrintArray(filteredArray);

        Console.ReadLine(); 
    }

    static string[] FilterShortStrings(string[] array)
    {
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] filteredArray = new string[count];
        int index = 0;

        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                filteredArray[index] = str;
                index++;
            }
        }

        return filteredArray;
    }

    static void PrintArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i != array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}
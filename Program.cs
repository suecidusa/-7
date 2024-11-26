using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = { 5, 2, 9, 1 };
        int[] array2 = { 4, 8, 6, 3 };

        // Сортировка по возрастанию
        int[] sortedAsc = SortAscending(array1);
        Console.WriteLine("Сортировка по возрастанию: " + string.Join(", ", sortedAsc));

        // Сортировка по убыванию
        int[] sortedDesc = SortDescending(array2);
        Console.WriteLine("Сортировка по убыванию: " + string.Join(", ", sortedDesc));

        // Объединение двух массивов
        int[] mergedArray = MergeArrays(array1, array2);
        Console.WriteLine("Объединённый массив: " + string.Join(", ", mergedArray));
    }

    public static int[] SortAscending(int[] arr)
    {
        Array.Sort(arr);
        return arr;
    }

    public static int[] SortDescending(int[] arr)
    {
        Array.Sort(arr);
        Array.Reverse(arr);
        return arr;
    }

    public static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        int[] mergedArray = new int[arr1.Length + arr2.Length];
        Array.Copy(arr1, mergedArray, arr1.Length);
        Array.Copy(arr2, 0, mergedArray, arr1.Length, arr2.Length);
        return mergedArray;
    }
}

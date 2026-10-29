using System;

class InsertionSortExample
{
    static void Main(string[] args)
    {
        int[] data = { 64, 25, 12, 22, 11 };

        Console.WriteLine("Original array:");
        PrintArray(data);

        InsertionSort(data);

        Console.WriteLine("\nSorted array in ascending order:");
        PrintArray(data);
    }

    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;

        // Outer loop starts at index 1 (the first unsorted card)
        for (int i = 1; i < n; i++)
        {
            int key = arr[i]; // The current card we want to insert
            int j = i - 1;    // The index of the card right before it

            // Shift elements of the sorted part that are greater than the key
            // to one position ahead of their current position
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j]; // Shift right
                j = j - 1;           // Move pointer left
            }

            // Insert the key into its correct sorted location
            arr[j + 1] = key;
        }
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }
}

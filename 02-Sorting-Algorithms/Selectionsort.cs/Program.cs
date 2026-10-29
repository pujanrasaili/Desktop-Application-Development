using System;

class SelectionSortExample
{
    static void Main(string[] args)
    {
        int[] data = { 64, 25, 12, 22, 11 };

        Console.WriteLine("Original array:");
        PrintArray(data);

        SelectionSort(data);

        Console.WriteLine("\nSorted array in ascending order:");
        PrintArray(data);
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        // Outer loop moves the boundary of the unsorted subarray
        for (int i = 0; i < n - 1; i++)
        {
            // Assume the current element is the minimum
            int minIndex = i;

            // Inner loop searches the remaining unsorted elements
            for (int j = i + 1; j < n; j++)
            {
                // To sort in descending order, change '<' to '>'
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j; // Found a smaller element, update index
                }
            }

            // Swap the found minimum element with the first element of the unsorted part
            if (minIndex != i)
            {
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }
}

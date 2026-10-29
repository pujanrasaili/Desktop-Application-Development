using System;

class BubbleSortExample
{
    static void Main(string[] args)
    {
        int[] data = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Original array:");
        PrintArray(data);

        BubbleSort(data);

        Console.WriteLine("\nSorted array in ascending order:");
        PrintArray(data);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        // Outer loop for the number of passes
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            // Inner loop for adjacent comparisons
            // (n - i - 1) avoids checking already sorted elements at the end
            for (int j = 0; j < n - i - 1; j++)
            {
                // To sort in descending order, change '>' to '<'
                if (arr[j] > arr[j + 1])
                {
                    // Clean C# tuple swap (no temporary variable needed)
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);

                    swapped = true; // Mark that a swap occurred
                }
            }

            // Optimization: If no elements were swapped, the array is already sorted
            if (!swapped)
            {
                break;
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }
}

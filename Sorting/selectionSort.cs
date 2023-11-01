using ArrayProblems;
namespace SortingAlgo;

class Sorting
{
    public static void SelectionSort()
    {
        int[] arr = { 10, 18, 12, 23, 45, 56 };
        int size = arr.Length;
        for (int i = 0; i < size - 1; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (arr[i] > arr[j])
                {
                    swap(arr, i, j);
                }
            }
        }
        ArrayProblem.PrintItems(arr);
    }

    private static void swap(int[] arr, int i, int j)
    {
        (arr[j], arr[i]) = (arr[i], arr[j]);
    }
}
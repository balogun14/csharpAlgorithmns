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
    public static void BubbleSort()
    {
        int[] arr = { 10, 18, 12, 23, 45, 56 };
        int swapped = 0; //This is for optimization 
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    swap(arr, j, j + 1);
                    swapped = 1;
                }
                else
                {
                    swapped = 0;
                }
            }
            if (swapped == 0)
            {
                break;
            }
        }
        ArrayProblem.PrintItems(arr);
    }

    private static void swap(int[] arr, int i, int j)
    {
        (arr[j], arr[i]) = (arr[i], arr[j]);
    }
}
namespace ArrayProblems;

class ArrayProblem
{
    public static void RemoveDuplicates()
    {
        int[] SortedArray = { 1, 1, 1, 2, 2, 3, 3, 4 };
        int len = 0;
        for (int i = 0; i < SortedArray.Length - 1; i++)
        {
            if (SortedArray[i] != SortedArray[i + 1])
            {
                len++;
            }
        }
        SortedArray[len++] = SortedArray[^1];
        Console.WriteLine(len);

    }
    public static void RotateByKtimes()
    {
        /*
        This is the problem: You are to rotate an array a given
        number of times k e.g You are given an array of this elements
        {a,b,c,d,e} so rottaing this when k = 2 should give 
        {e,a,b,c,d} the first time and {d,e,a,b,c} the second time
        */
        
        int[] arr = { 1, 2, 3, 4, 5 };
        int n = arr.Length;
        int k = 2; //Times to roatate
        for (int i = 0; i < k; i++)
        {
            (arr[n - 1], arr[0]) = (arr[0], arr[n - 1]);
            MoveArray(arr, n);
        }
        PrintItems(arr);
        //Expected output {4,5,1,2,3} got this instead {4,4,5,2,3}

    }
    public static void MoveArray(int[] arr, int n)
    /*
    This swaps the position of the elements.
    e.g we have an array with elements {a,b,c,d,e}
    it will be {e,a,b,c,d}
    */
    {
        for (int j = n - 1; j > 0; j--)
        {
            arr[j] = arr[j - 1];
        }
    }
    public static void PrintItems(int[] arr)
    {
        /*
        This prints out all the element in the array
        */
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}
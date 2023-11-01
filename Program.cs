using DsaProblems;
using arrayClass.bitwiseProblems;
using SortingAlgo;
class Program
{
    public static void Main()
    {
        // int[] plots = { 1, 7, 4, 1, 4, 1, 3, 2, 1, 1 };
        // int n = plots.Length;
        // int k = 8;
        // SlidingWindowProblem.Housing(plots, n, k);


        // HashTableWithQuadraticProbing hash = new();
        // hash.Insert(10);
        // hash.Insert(4);
        // hash.Insert(2);
        // hash.Insert(15);
        // hash.Insert(5);
        // hash.Insert(6);
        // hash.Insert(6);
        // hash.Insert(0);

        // hash.PrintHashTable();
        // hash.Print();
        // Console.WriteLine(Environment.NewLine);
        // int result = hash.Search(35);
        // if (result == 1)
        // {
        //     Console.WriteLine("result Found");

        // }
        // else
        // {
        //     Console.WriteLine("No result Found");

        // }

        // FindingEvenNumbers.Start();

        // CountSetBit.Start();
        // ArrayProblems.ArrayProblem.RotateByKtimes();
        Sorting.BubbleSort();

    }
    public static void PrintDivisor(int n)
    {
        for (int i = 1; i < Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                if (n / i == i)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i + " " + n / i);
                }
            }
        }
    }
}
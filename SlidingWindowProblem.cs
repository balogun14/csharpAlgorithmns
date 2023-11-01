using System.Collections.Generic;
namespace DsaProblems
{
    public class SlidingWindowProblem
    {
        public static void Housing(int[] arr, int n, int k)
        {
            int i = 0;
            int j = 0;
            int currentSum = 0;
            while (j < n)
            {
                //Expand to the right
                currentSum += arr[j];
                // Console.WriteLine(currentSum);
                j++;
                //Remove element from the left if cs is > k and i<j
                while (currentSum > k && i < j)
                {
                    currentSum -= arr[i];
                    i++;
                }
                //id at any given point current sum is 
                if (currentSum == k)
                {
                    Console.WriteLine($"{i} - {j - 1}");

                }
            }
        }
        // public void string UniqueSubstring(string str){
        //     int i = 0, j = 0;
        //     Dictionary<char,int> m = new();
        //     while (j<str.Length)
        //     {
        //         char ch = str[i];
        //         if (m.Count(ch) && m[ch] >=1)
        //         {
                    
        //         }
        //     }
        // }
        
    }
}
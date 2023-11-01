using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arrayClass.bitwiseProblems
{
    public class CountSetBit
    {
        public static void Start()
        {
            Console.WriteLine("Unsigned bit n: ");
            int n = int.Parse(Console.ReadLine()!);
            int count = 0;
            while (n != 0)
            {
                if ((n & 1) == 1) count++;
                n >>= 1;
            }
            Console.WriteLine(count);
            
        }
    }
}
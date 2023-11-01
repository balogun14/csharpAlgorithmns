namespace DsaProblems
{
    public class HashTableImplementationWithLinearProbing
    {
        static int Size = 5;
        static int[] arr = new int[Size];
        public HashTableImplementationWithLinearProbing()
        {
            int i;
            for (i = 0; i < Size; i++)
            {
                arr[i] = -1;
            }
        }
        public  int Insert(int value)
        {
            int key = value % Size;
            int index = key;
            while (arr[index] != -1)
            {
                index = (index + 1) % Size;
                if (index == key)
                {
                    Console.WriteLine("Hash Table is Full");
                    return 0;
                }
            }
            arr[index] = value;
            return 1;
        }
        public  void PrintHashTable()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");

            }
        }
    }
}
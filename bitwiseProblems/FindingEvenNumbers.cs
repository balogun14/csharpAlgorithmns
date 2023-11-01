namespace arrayClass.bitwiseProblems
{
    public class FindingEvenNumbers
    {
        public static void Start()
        {
            Console.Write("What number do you want to check: ");
            int number = int.Parse(Console.ReadLine()!);

            int bitMask = 0001;
            int numbera = number & bitMask;
            if (numbera == 0)
            {
                Console.WriteLine("Even ");

            }
            else
            {
                Console.WriteLine("odd");

            }
        }





    }
}
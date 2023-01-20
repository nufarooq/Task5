namespace EvenIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 Numbers");
            int total = 10;
            int[] numbers = new int[total];
            for(int i=0; i< total; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Even Numbers Entered Are : ");
            for (int i = 0; i < total; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
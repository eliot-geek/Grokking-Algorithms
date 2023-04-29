namespace _09SumArray
{
    internal class Program
    {
        /// <summary>
        /// The SumArray function takes an integer array as input and recursively sums its elements
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int SumArray(int[] arr)
        {
            // base case
            if (arr.Length == 0)
            {
                return 0;
            }
            // recursive case
            else
            {
                return arr[0] + SumArray(arr[1..]);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = SumArray(arr);
            Console.WriteLine(sum);
        }
    }
}
namespace _02LoopSum
{
    internal class Program
    {
        /// <summary>
        /// Calculates the sum of all the elements in an array and takes an array as an input parameter.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>returns the total sum and The return type of the function is an integer</returns>
        static int Summ(int[] arr)
        {
            // A variable 'total' is declared and initialized to 0.
            int total = 0;

            // The loop continues until all the elements of the array have been processed.
            for (int i = 0; i < arr.Length; i++)
            {
                // The current element 'x' is added to the running total.
                total += arr[i];
            }
            // The final total is returned by the function.
            return total;
        }

        /// <summary>
        /// This method calculates the sum of all the elements in an enumerable collection of integers and returns the total sum.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int Sum(IEnumerable<int> arr)
        {
            var total = 0;
            foreach (var x in arr)
            {
                total += x;
            }
            return total;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Summ(new int[] { 1, 2, 3, 4 }));

            Console.WriteLine(Sum(new[] { 1, 2, 3, 4 }));
        }
    }
}
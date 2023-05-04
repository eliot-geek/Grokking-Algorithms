namespace _03RecursiveSum
{
    internal class Program
    {
        /// <summary>
        /// This method calculates the sum of all the elements in a list and returns the total sum.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        static int Summ(int[] list)
        {
            // Base case: An empty list has a sum of 0.
            if (list.Length == 0)
            {
                return 0;
            }
            // Recursive case
            else
            {
                // The sum of the list is calculated as the sum of the first element of the list and the sum of the rest of the list.
                return list[0] + Summ(list.Skip(1).ToArray());
            }
        }

        /// <summary>
        /// This method calculates the sum of all the elements in an enumerable collection of integers using recursion.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private static int Sum(IEnumerable<int> list)
        {
            // If the input collection 'list' is empty, the sum is 0. This is the base case for the recursion.
            if (!list.Any())
                return 0;

            // The sum is calculated as the sum of the first element of the list and the sum of the rest of the list.
            // The 'Take' method returns the first element of the input collection, and the 'Skip' method returns the rest of the collection.
            // The Sum method is called recursively on the rest of the collection.
            return list.Take(1).First() + Sum(list.Skip(1));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Summ(new int[] { 1, 2, 3, 4 }));

            Console.WriteLine(Sum(new[] { 1, 2, 3, 4 }));
        }
    }
}
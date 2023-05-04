namespace _04RecursiveCount
{
    internal class Program
    {
        /// <summary>
        /// This method recursively counts the number of elements in a list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        static int Count(int[] list)
        {
            // Base case: An empty list has a count of 0.
            if (!list.Any())
            {
                return 0;
            }
            // Recursive case
            else
            {
                // The count of the list is calculated as 1 plus the count of the rest of the list.
                // The 'Skip' method returns the rest of the collection.
                return 1 + Count(list.Skip(1).ToArray());
            }
        }

        private static int Count(IEnumerable<int> list)
        {
            if (!list.Any()) 
                return 0;

            return 1 + Count(list.Skip(1));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Count(new int[] { 1, 2, 3, 4 }));

            Console.WriteLine(Count(new[] { 1, 2, 3, 4 }));
        }
    }
}
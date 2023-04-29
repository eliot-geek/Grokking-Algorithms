namespace _06Count
{
    internal class Program
    {
        /// <summary>
        /// The function Count takes an integer array arr as an argument and returns the number of elements in the array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int Count(int[] arr)
        {
            // Base case
            if (arr.Length == 0)
            {
                return 0;
            }
            // Recursive case
            else
            {
                return 1 + Count(arr[1..]); // allows you to get a slice of an array starting from a specific index to the end of the array.
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(Count(arr)); // Output: 5
        }
    }
}
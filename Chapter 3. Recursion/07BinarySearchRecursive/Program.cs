namespace _07BinarySearchRecursive
{
    internal class Program
    {
        /// <summary>
        /// The method BinarySearch takes two parameters: an array of integers arr and a target integer target to search for in the array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        static int BinarySearch(int[] arr, int target)
        {
            // if the array is empty, return -1
            if (arr.Length == 0)
            {
                return -1;
            }

            // initialize low and high indices
            int low = 0;
            int high = arr.Length - 1;

            // calculate the middle index
            int mid = (low + high) / 2;

            // check if the middle element is the target
            if (arr[mid] == target)
            {
                return target;
            }
            // if the middle element is greater than the target, search the left half
            else if (arr[mid] > target)
            {
                return BinarySearch(arr[..mid], target); // slice notation in C# using '..'
            }
            // if the middle element is less than the target, search the right half
            else
            {
                return BinarySearch(arr[(mid + 1)..], target);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch(new int[] { 6, 7, 8, 9, 10 }, 8));
            Console.WriteLine(BinarySearch(new int[] { 6, 7, 8, 9, 10 }, 6));

        }
    }
}
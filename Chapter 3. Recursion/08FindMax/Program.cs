namespace _08FindMax
{
    internal class Program
    {
        // Define a method named FindMax that takes an array of integers as input and returns an integer
        static int FindMax(int[] arr)
        {
            // Base case: if the array is empty, return 0
            if (arr.Length == 0)
            {
                return 0;
            }
            // Base case: if the array has only one element, return that element
            else if (arr.Length == 1)
            {
                return arr[0];
            }
            // Base case: if the array has only two elements, return the maximum of the two elements
            else if (arr.Length == 2)
            {
                return arr[0] > arr[1] ? arr[0] : arr[1];
            }
            // Recursive case: find the maximum of the rest of the array recursively and compare it with the first element of the array
            int subMax = FindMax(arr[1..]);
            return arr[0] > subMax ? arr[0] : subMax;
        }

        static void Main(string[] args)
        {
            // Test the FindMax method
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 9, 4, 3, 2, 1 };
            int[] arr3 = new int[] { 1, 3, 2, 8, 4 };
            Console.WriteLine(FindMax(arr1)); // output: 5
            Console.WriteLine(FindMax(arr2)); // output: 9
            Console.WriteLine(FindMax(arr3)); // output: 8
        }
    }
}
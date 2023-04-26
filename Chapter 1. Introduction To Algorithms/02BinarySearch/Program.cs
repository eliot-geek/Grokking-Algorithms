using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace _02BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Binary Search

            // Binary search
            // Suppose you’re searching for a word in a dictionary, and it starts with O. You could start at the beginning and keep lipping pages until you
            // get to the Os. But you’re more likely to start at a page in the middle, because you know the Os are going to be near the middle of the dictionary.
            // This is a search problem. Binary search is an algorithm; its input is a sorted list of elements. If an element you’re
            // looking for is in that list, binary search returns the position where it’s located.Otherwise, binary search returns null.

            // With binary search, you guess the middle number and eliminate half the remaining numbers every time. Eliminate half the numbers every time with binary search.
            // I’m thinking of a number between 1 and 100. So 100-- > 50 --> 25 --> 13 --> 7 --> 4 --> 2 --> 1 ===> only 7 steps  

            // he dictionary has 240,000 words.
            // Simple search could take 240,000 steps if the word you’re looking for is the very last one in the book.
            // With each step of binary search, you cut the number of words in half until you’re let with only one word.
            // 240k --> 120k --> 60k --> 30k --> 15k --> 7.5k --> 3750 --> 1875 --> 938 --> 469 --> 235 --> 118 --> 59 --> 30 --> 15 --> 8 --> 4 --> 2 --> 1 ==> 18 steps 
            // In general, for any list of n, binary search will take log2 n steps to run in the worst case, whereas simple search will take n steps.

            // Logarithms 
            // log10 100 = 2.   log10 1000 = 3.  log10 10000 = 4.  log10 100000 = 5.
            // log2 8 = 3.      log2 16 = 4.     log2 32 = 5.

            // In this book, when I talk about running time in Big O notation (explained a little later), log always means log2.
            // When you search for an element using simple search, in the worst case you might have to look at every single element.So for a list of 8 numbers, you’d have to check 8 numbers at most.
            // For binary search, you have to check log n elements in the worst case. For a list of 8 elements, log 8 == 3, because 23 == 8.So for a list of 8 numbers,
            // you would have to check 3 numbers at most.For a list of 1, 024 elements, log 1, 024 = 10, because 210 == 1, 024.So for a list of 1, 024 numbers, you’d
            // have to check 10 numbers at most.

            // Binary search only works when your list is in sorted order. For example, the names in a phone book are sorted in alphabetical order, so you can
            // use binary search to look for a name.
            #endregion

            // Write binary search

            var myList = new int[] { 1, 3, 5, 7, 9 };
            Console.WriteLine(BinarySearch(myList, 3));  // => 1
            Console.WriteLine(BinarySearch(myList, -1) != null ? BinarySearch(myList, -1).ToString() : "None"); // => None
        }

        // Returns the index of the target element in the array using binary search, or -1 if not found
        // Assumes the array is sorted in ascending order
        public static int? BinarySearch(int[] arr, int item)
        {
            int low = 0;                // the left bound of the search range
            int high = arr.Length - 1;  // the right bound of the search range

            while (low <= high)
            {
                // the middle index of the search range
                int mid = low + (high - low) / 2; 

                if (arr[mid] == item)
                {
                    // found the target element
                    return mid; 
                }
                else if (arr[mid] < item)
                {
                    // the target element is in the right half
                    low = mid + 1; 
                }
                else
                {
                    // the target element is in the left half
                    high = mid - 1; 
                }
            }
            // target element not found in the array
            return null; 
        }
    }
}
using System.Drawing;

namespace _03Exercices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1.1
            // 1.1 Suppose you have a sorted list of 128 names, and you’re searching through it using binary search.
            // What’s the maximum number of steps it would take?
            // Answer : In binary search, the maximum number of steps required to search through a sorted list of n items is log2(n).
            // In this case, we have a sorted list of 128 names. So, the maximum number of steps required to search through this list using binary search is: 
            // log2(128) = 7
            #endregion

            #region Task 1.2
            // Suppose you double the size of the list. What’s the maximum number of steps now?
            // Answer : If we double the size of the list from 128 to 256, the maximum number of steps required to search through it using binary search would be:
            // log2(256) = 8
            #endregion

            Console.WriteLine("Exercices!");
        }
    }
}
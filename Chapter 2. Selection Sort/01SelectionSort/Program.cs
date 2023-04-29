using System.Collections.Generic;
using System.Xml.Linq;
using System;

namespace _01SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // How memory works
            // Arrays and linked lists
            // Linked lists
            // Arrays
            // Terminology

            // Here are the run times for common operations on arrays and lists.
            //                  Arrays  Lists
            // Reading          O(1)    O(n)
            // Insertion        O(n)    O(1) 
            // O(1) - Constant Time
            // O(n) - Linear Time

            // Why does it take O(n) time to insert an element into an array? 
            // When you insert an element into an array, you may need to shift all the elements to the right of the insertion point to make room for the new
            // element. The time it takes to insert an element into an array is proportional to the number of elements that need to be shifted, which is
            // typically O(n) in the worst case, where n is the size of the array.

            // Suppose you wanted to insert an element at the beginning of an array.
            // How would you do it?
            // You would need to shift all the existing elements in the array to the right by one position to make room for the new element. To do this, you could
            // iterate over the array from right to left, moving each element one position to the right until you reach the first element of the array.
            // You would then insert the new element at the beginning of the array.

            // How long would it take?
            // The time it takes to insert an element at the beginning of an array is also O(n) in the worst case, because you would need to shift all the existing
            // elements in the array to make room for the new element. However, in some cases, you may be able to optimize the insertion by using a linked list
            // instead of an array, where inserting an element at the beginning of a linked list can be done in O(1) time.

            Console.WriteLine("Selection Sort!");
        }
    }
}
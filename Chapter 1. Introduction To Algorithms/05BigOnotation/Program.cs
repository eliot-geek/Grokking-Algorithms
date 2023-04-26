namespace _05BigOnotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Big O notation is special notation that tells you how fast an algorithm is. Big O notation tells you how fast an algorithm is.

            /* Algorithm running times grow at diferent rates
            Running time for simple search vs. binary search, with a list of 100 elements 
            With simple search, the search takes 100 ms to run. 
            With binary search , It only has to check 7 elements (log2 100 is roughly 7), so that search takes 7 ms to run. 
            
            But realistically, a list can have more like a billion elements. If it does, 
            how long will simple search take?   1_000_000_000_000
            How long will binary search take?   log2(1_000_000_000_000) = 30  ==== log2 (1,000,000,000) ≈ 29.897352853986263
            
            Run times grow at very different speeds!
                                Simple Search           Binary Search
            100                 100 ms                  7 ms
            10.000              10 s                    14 ms
            1.000.000.000       11 days                 30 ms

            That is, as the number of items increases, binary search takes a little more time to run. But simple search takes a lot more time to run.
            We need to know how the running time increases as the list size increases. That’s where Big O notation comes in.

            The run time in Big O notation is O(n). where n is the number of operations
            Binary search needs log n operations to check a list of size n. It’s O(log n).  */

            /* Visualizing diferent Big O run times 
            Suppose you have to draw a grid of 16 boxes.
            Algorithm 1 : One way to do it is to draw 16 boxes, one at a time. 
            Algorithm 2 : Try this algorithm instead. Fold the paper. Fold the paper again, and again, and again.
            Answers: Algorithm 1 takes O(n) time, and algorithm 2 takes O(log n) time. */

            /* Big O establishes a worst-case run time
            Simple search still takes O(n) time. It’s a reassurance—you know that simple search will never be slower than O(n) time. 
            Note : Along with the worst-case run time, it’s also important to look at the average-case run time. */

            /* Some common Big O run times 
            Here are ive Big O run times that you’ll encounter a lot, sorted from fastest to slowest:
            • O(log n), also known as log time. Example: Binary search.
            • O(n), also known as linear time. Example: Simple search.
            • O(n * log n). Example: A fast sorting algorithm, like quicksort
            • O(n2). Example: A slow sorting algorithm, like selection sort
            • O(n!). Example: A really slow algorithm, like the traveling salesperson.
            Here’s how long it would take to draw a grid for the rest of the algorithms, from fastest to slowest: (picture)
            

            • Algorithm speed isn’t measured in seconds, but in growth of the number of operations.
            • Instead, we talk about how quickly the run time of an algorithm increases as the size of the input increases.
            • Run time of algorithms is expressed in Big O notation.
            • O(log n) is faster than O(n), but it gets a lot faster as the list of items you’re searching grows. */

            Console.WriteLine("Big O notation");
        }
    }
}
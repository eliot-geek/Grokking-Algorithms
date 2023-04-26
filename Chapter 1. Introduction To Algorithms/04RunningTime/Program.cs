namespace _04RunningTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Generally you want to choose the most eicient algorithm — whether you’re trying to optimize for time or space.
            If this is a list of 100 numbers, it takes up to 100 guesses. If it’s a list of 4 billion numbers, it takes up to 4 billion guesses. 
            So the maximum number of guesses is the same as the size of the list. his is called linear time.
            Binary search is diferent. If the list is 100 items long, it takes at most 7 guesses. If the list is 4 billion items, it takes at most 32 guesses.

            Linear Time      = O(n)
            Logarithmic Time = O(log n)

            */
            Console.WriteLine("Running time!");
        }
    }
}
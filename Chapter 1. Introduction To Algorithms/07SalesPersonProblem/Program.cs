namespace _07SalesPersonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The salesperson has to go to ive cities and wants to hit all ive cities while traveling the minimum distance. Here’s one way to do that: look
            // at every possible order in which he could travel to the cities. here are 120 permutations with 5 cities, so it will take 120 operations to solve
            // the problem for 5 cities.For 6 cities, it will take 720 operations(there are 720 permutations). For 7 cities, it will take 5, 040 operations!
            // The number of operations increases drastically.

            // In general, for n items, it will take n! (n factorial) operations to compute the result.So this is O(n!) time, or factorial time.It takes a lot of
            // operations for everything except the smallest numbers.Once you’re dealing with 100 + cities, it’s impossible to calculate the answer in time —
            // the Sun will collapse first.
            // This is a terrible algorithm! Opus should use a diferent one, right? But he can’t. This is one of the unsolved problems in computer science.
            // There’s no fast known algorithm for it, and smart people think it’s impossible to have a smart algorithm for this problem.

            Console.WriteLine("Salesperson Problem!");
        }
    }
}
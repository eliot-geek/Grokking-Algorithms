namespace _03Countdown
{
    internal class Program
    {
        /// <summary>
        /// This function takes an integer i as its parameter and counts down from i to 1 recursively
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        static int Countdown(int i)
        {
            // base case: if i is less than or equal to 0, stop recursion and return 0
            if (i <= 0)
            {
                return 0;
            }
            // recursive case: print i and call Countdown function with i-1 as its argument
            else
            {
                Console.WriteLine(i);
                return Countdown(i - 1);
            }
        }

        static void Main(string[] args)
        {
            // calls Countdown function with an argument of 5
            Countdown(5);
        }
    }
}
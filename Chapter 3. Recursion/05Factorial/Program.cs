namespace _05Factorial
{
    internal class Program
    {
        // A recursive function to calculate the factorial of a given number
        static int Factorial(int n)
        {
            // Base case
            if (n == 1)
            {
                return 1;
            }
            // Recursive case
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static void Main(string[] args)
        {
            // Prints the factorial of 5
            Console.WriteLine(Factorial(5)); 
        }
    }
}
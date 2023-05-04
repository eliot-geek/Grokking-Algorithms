namespace _07GreatestCommonDivisor
{
    internal class Program
    {
        /// <summary>
        /// This method calculates the greatest common divisor (GCD) of two integers using recursion and the modulo operator
        /// It takes two integers as input parameters: FirstNumber and SecondNumber
        /// </summary>
        /// <param name="FirstNumber"></param>
        /// <param name="SecondNumber"></param>
        /// <returns> It returns an integer value that represents the GCD of the two input integers</returns>
        public static int GetGCD(int FirstNumber, int SecondNumber)
            => SecondNumber == default ? FirstNumber : GetGCD(SecondNumber, FirstNumber % SecondNumber);

        /// <summary>
        /// This method calculates the GCD of a list of integers using recursion and the GetGCD method
        /// It takes a list of integers as input parameter: lst
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        public static int GetGCDList(List<int> lst)
        {
            // Initialize the result with the first element of the list.
            var result = lst[0];
            // Iterate over the rest of the list and get the GCD between the result and each element. Store the result in 'result'.
            result = GetGCD(result, lst.Skip(1).FirstOrDefault());
            // Return the final GCD value
            return result;
        }

        static void Main(string[] args)
        {
            // Sample list of integers to find GCD for
            var lst = new List<int> { 32, 696, 40, 50 };
            
            // Find the GCD of two integers
            var GCD = GetGCD(640, 1680);
            
            // Find the GCD of a list of integers.
            var GCDList = GetGCDList(lst);

            // Print the results
            Console.WriteLine(GCD);
            Console.WriteLine(GCDList);
        }
    }
}
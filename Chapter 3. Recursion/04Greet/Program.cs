namespace _04Greet
{
    internal class Program
    {
        // Define a function that takes a name parameter and prints a greeting
        public static void Greet(string name)
        {
            Console.WriteLine("hello, " + name + "!");
            // Call the Greet2 function
            Greet2(name);
            Console.WriteLine("getting ready to say bye...");
            // Call the Bye function
            Bye();
        }

        // Define a function that takes a name parameter and prints a question
        public static void Greet2(string name)
        {
            Console.WriteLine("how are you, " + name + "?");
        }

        // Define a function that prints a farewell message
        public static void Bye()
        {
            Console.WriteLine("ok bye!");
        }


        static void Main(string[] args)
        {
            // Call the Greet function with "adit" as the argument
            Greet("Eliot");
        }
    }
}
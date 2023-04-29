namespace _01Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Recursion
            
            Pseudocode is a high-level description of the problem you’re trying to solve, in code. It’s written like code, but it’s meant to be closer to human speech.
            Leigh Caldwell on Stack Overlow: “Loops may achieve a performance gain for your program. Recursion may achieve a performance gain for your programmer. 
            Choose which is more important in your situation!”

            Base case and recursive case
            Every recursive function has two parts: the base case, and the recursive case. The recursive case is when the function calls itself. 
            The base case is when the function doesn’t call itself again … so it doesn’t go into an ininite loop.

            The stack
            The call stack is an important concept in general programming. When you insert an item, it gets added to the top of the list. 
            When you read an item, you only read the topmost item, and it’s taken of the list. So your list has only two actions: push (insert) and pop (remove and read).
            The stack is a simple data structure. 

            The call stack
            Your computer uses a stack internally called the call stack.
            When you call a function from another function, the calling function is paused in a partially completed state. 
            All the values of the variables for that function are still stored in memory.
            This stack, used to save the variables for multiple functions, is called the call stack.

            The call stack with recursion
            Recursive functions use the call stack too! Let’s look at this in action with the factorial function. factorial(5) is written as 5!, and it’s deined like this: 
            5! = 5 * 4 * 3 * 2 * 1. Similarly, factorial(3) is 3 * 2 * 1. 
            Remember, the topmost box in the stack tells you what call to fact you’re currently on.
            Notice that each call to fact has its own copy of x. You can’t access a diferent function’s copy of x.

            Using the stack is convenient because you don’t have to keep track of a pile of boxes yourself—the stack does it for you.
            Using the stack is convenient, but there’s a cost: saving all that info can take up a lot of memory. Each of those function calls takes up some memory, and when your stack is too tall, that means your computer is
            saving information for many function calls. At that point, you have two options:
            • You can rewrite your code to use a loop instead.
            • You can use something called tail recursion. hat’s an advanced recursion topic that is out of the scope of this book. It’s also only supported by some languages, not all.



            Recap
            • Recursion is when a function calls itself.
            • Every recursive function has two cases: the base case and the recursive case.
            • A stack has two operations: push and pop.
            • All function calls go onto the call stack.
            • The call stack can get very large, which takes up a lot of memory.

            */
        }
    }
}
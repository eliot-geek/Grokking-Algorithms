using System.Numerics;
using System.Xml.Linq;
using System;
using System.Data;
using Microsoft.VisualBasic;
using System.Reflection.Metadata;

namespace _06Exercies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1.3
            // Give the run time for each of these scenarios in terms of Big O.
            // 1.3 You have a name, and you want to find the person’s phone number in the phone book.
            // Answer : O(log n)
            #endregion

            #region Task 1.4
            // 1.4 You have a phone number, and you want to find the person’s name in the phone book. (Hint: You’ll have to search through the whole
            // book!)
            // Answer : O(n) since i have to search through the entire phone book to find the person's name associated with the phone number.
            #endregion

            #region Task 1.5
            // 1.5 You want to read the numbers of every person in the phone book.
            // Answer : O(n) since i have to read the number of every person in the phone book.
            #endregion

            #region Task 1.6
            // 1.6 You want to read the numbers of just the As. (his is a tricky one!
            // It involves concepts that are covered more in chapter 4.Read the answer—you may be surprised!)
            // Answer: O(n). You may think, “I’m only doing this for 1 out of 26 characters, so the run time should be O(n / 26).”
            // A simple rule to remember is, ignore numbers that are added, subtracted, multiplied, or divided. None of these are correct Big O run times:
            // O(n + 26), O(n - 26), O(n * 26), O(n / 26). They’re all the same as O(n)! Why? If you’re curious, flip to “Big O notation revisited,” in chapter 4,
            // and read up on constants in Big O notation(a constant is just a number; 26 was the constant in this question).
            #endregion

            Console.WriteLine("Exercices!");
        }
    }
}
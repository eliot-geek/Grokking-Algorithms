namespace _05RecursiveMax
{
    internal class Program
    {
        /// <summary>
        /// This method recursively finds the maximum element in a list
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        static int? Max(int[] lst)
        {
            // Base case 1: An empty list has no maximum element. Return null.
            if (lst.Length == 0)
            {
                return null;
            }
            // Base case 2: A list with only one element has that element as the maximum. Return the element.
            else if (lst.Length == 1)
            {
                return lst[0];
            }
            // Recursive case
            else
            {
                // The maximum of the list is calculated as the maximum of the first element and the maximum of the rest of the list.
                // The 'Skip' method returns the rest of the collection.
                int? sub_max = Max(lst.Skip(1).ToArray());
                return lst[0] > sub_max ? lst[0] : sub_max;
            }
        }

        /// <summary>
        /// This method recursively finds the maximum element in a collection of integers.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private static int Max(IEnumerable<int> list)
        {
            // Base case 1: An empty list has no maximum element. Throw an exception.
            if (!list.Any())
                throw new ArgumentException(nameof(list));

            // Base case 2: A list with only one element has that element as the maximum. Return the element.
            if (list.Count() == 1) 
                return list.First();

            // Base case 3: A list with two elements has the maximum of the two elements. Return the maximum.
            if (list.Count() == 2) 
                return list.First() > list.Skip(1).Take(1).First() ? list.First() : list.Skip(1).Take(1).First();

            // Recursive case: Calculate the maximum of the list as the maximum of the first element and the maximum of the rest of the list.
            // The 'Skip' method returns the rest of the collection after the first element.
            var sub_max = Max(list.Skip(1));
            return list.First() > sub_max ? list.First() : sub_max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Max(new int[] { 10, 5, 2, 3 }));

            Console.WriteLine(Max(new List<int> { 10, 5, 2, 3 }));
            Console.WriteLine(Max(new[] { 1, 3, 2, 5, 9, 8 }));
        }
    }
}
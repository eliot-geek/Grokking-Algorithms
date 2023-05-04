namespace _06QuickSortAlgorithm
{
    internal class Program
    {
        /// <summary>
        /// The QuickSort method takes an IEnumerable<int> array as input and returns a sorted IEnumerable<int> array using the quicksort algorithm.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static IEnumerable<int> QuickSort(IEnumerable<int> array)
        {
            if (array.Count() < 2)
            {
                // Base case: arrays with 0 or 1 element are already "sorted"
                return array;
            }
            else
            {
                // Recursive case
                int pivot = array.First();
                // Sub-array of all the elements less than the pivot
                IEnumerable<int> less = array.Skip(1).Where(i => i <= pivot);
                // Sub-array of all the elements greater than the pivot
                IEnumerable<int> greater = array.Skip(1).Where(i => i > pivot);
                return QuickSort(less).Concat(new[] { pivot }).Concat(QuickSort(greater));
            }
        }

        /// <summary>
        /// The QuickSort method takes an IEnumerable<int> array as input and returns a sorted IEnumerable<int> array using the quicksort algorithm.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private static IEnumerable<int> QuickSort2(IEnumerable<int> list)
        {
            if (list.Count() <= 1) 
                return list;
            var pivot = list.First();
            var less = list.Skip(1).Where(i => i <= pivot);
            var greater = list.Skip(1).Where(i => i > pivot);
            return QuickSort2(less).Union(new List<int> { pivot }).Union(QuickSort2(greater));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", QuickSort(new[] { 10, 5, 2, 3 })));

            var arr = new[] { 10, 5, 2, 3 };
            Console.WriteLine(string.Join(", ", QuickSort2(arr)));
        }
    }
}
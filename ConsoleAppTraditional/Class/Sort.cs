namespace ConsoleAppTraditional.Class
{
    public class Sort
    {
        public static void SortArray<T>(T[]array) where T : IComparable<T>
        {
            Array.Sort(array);
            foreach(var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}

namespace ConsoleAppTraditional.UTs
{
    public class ListManipulator
    {
        public static int FindMax(List<int> numbers)
        {
            return numbers.Max();
        }


        public static List<int> RemoveDuplicates(List<int> numbers)
        {
            return numbers.Distinct().ToList();
        }
    }

}

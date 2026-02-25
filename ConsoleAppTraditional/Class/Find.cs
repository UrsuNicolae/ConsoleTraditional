namespace ConsoleAppTraditional.Class
{
    public class Find
    {
        public static T? FindItem<T>(List<T> list, Func<T, bool> predicate)
        {
            return list.FirstOrDefault(predicate);
        }
    }
}

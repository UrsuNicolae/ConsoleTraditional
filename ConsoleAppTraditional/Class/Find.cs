namespace ConsoleAppTraditional.Class
{
    public class Find
    {
        public static T? FindItem<T>(List<T> list, Func<T, bool> predicate) where T : class, new()
        {
            return list.FirstOrDefault(predicate);
        }
    }

    internal interface IGenericInterface<T> { }

    public class GenericClass : IGenericInterface<string>
    {

    }
}

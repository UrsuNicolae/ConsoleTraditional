namespace ConsoleAppTraditional.Class
{
    public class PhoneBook
    {
        private static Dictionary<string, string> phoneNumbers = new();
        public static void AddPhoneNumber(string name, string phoneNumber)
        {
            if (phoneNumbers.ContainsKey(name))
            {
                Console.WriteLine($"Numarul de telefon pentru {name} este deja adaugat!");
            }
            else
            {
                phoneNumbers[name] = phoneNumber;
                Console.WriteLine($"Numarul de telefon a fost salvat pentru {name}");
            }
        }

        public static void RemovePhoneNumber(string name)
        {
            if (phoneNumbers.Remove(name))
            {
                Console.WriteLine($"Numarul de telefon pentru {name} a fost sters!");
            }
            else
            {
                Console.WriteLine($"Numarul de telefon nu a putu fi sters pentru {name}");
            }
        }

        public static string FindPhoneNumber(string name)
        {

            if (phoneNumbers.ContainsKey(name))
            {
                return phoneNumbers[name];
            }
            else
            {
                Console.WriteLine("Numarul nu a put fi gasit petnru {0}", name);
                return null;
            }
        }
    }
}

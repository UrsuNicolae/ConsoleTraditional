namespace ConsoleAppTraditional.UTs
{
    public class MathUtils
    {
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;


            return n * Factorial(n - 1);
        }


        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;


            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }


            return true;
        }
    }

}

namespace ConsoleAppTraditional.Class
{
    public class ComplexNumber
    {
        public readonly double ReadonlyValue = 1;
        public double Real { get; init; }

        public double Imaginar { get; set; }

        public static ComplexNumber operator +(ComplexNumber nr1, ComplexNumber nr2)
        {
            return new ComplexNumber { Real = nr1.Real + nr2.Real, Imaginar = nr1.Imaginar + nr2.Imaginar };
        }
        
        public static ComplexNumber operator +(ComplexNumber nr1, int nr2)
        {
            return new ComplexNumber { Real = nr1.Real + nr2, Imaginar = nr1.Imaginar + nr2 };
        }

        public override string ToString()
        {
            return $"Real: {Real}, Imaginar: {Imaginar}";
        }
    }
}

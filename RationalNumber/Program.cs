using System;

namespace RationalNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            C# has several numeric types, including natural, real, and irrational numbers.
            One numeric type that's missing is a Rational number.
            A rational number, as the name suggests is a ratio between 2 natural numbers and is usually represented as a fraction in the form 1/2, 5/4, -79/13, etc.

            Create a C# struct with a constructor that takes two integer parameters, either or both of which may be positive or negative.
            Include two read-only properties, Numerator and Denominator, that return the numerator and denominator of the fraction respectively of type int. 

            The numerator may be zero, but if the denominator is zero an ArgumentException should be raised by the constructor function.
            The Numerator and Denominator values should be reduced to their lowest possible integer values to maintain the ratio (examples r2 and r4 above).
            If the resulting fraction is a whole number, the Denominator should return 1 but the ToString() method should only show the integer value (example r3 above).
            If one of the values of numerator and denominator is negative, the sign is shown on the Numerator and the Denominator is positive (example r3 above).
            If both the numerator and denominator are negative, the fraction is positive and both Numerator and Denominator are positive (example r4 above).
            If the numerator is zero, the denominator should be set to 1, regardless of the value passed to the constructor.
             */


            int real, imaginary;
            string user;
            bool success;

            do
            {
                Console.WriteLine("Enter real part of the number");
                user = Console.ReadLine();
                success = int.TryParse(user, out real);
            } while (!success);

            do
            {
                Console.WriteLine("Enter imaginary part of the number");
                user = Console.ReadLine();
                success = int.TryParse(user, out imaginary);
            } while (!success);

            var r1 = new Rational(real, imaginary);
            Console.WriteLine("Real part: "+r1.Numerator);
            Console.WriteLine("Imaginary part: "+r1.Denominator);
            Console.WriteLine("Whole number: "+r1.Ratio());
        }
    }
}

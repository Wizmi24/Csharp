using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumber
{
    public class Rational
    {
        private readonly int _numerator;
        private readonly int _denominator;

        public Rational(int Numerator, int Denominator)
        {

            if (Denominator == 0)
            {
                throw new ArgumentException("Demominator can't be 0");
            }
            else
            {
                var sign = 1;
                if (Numerator<0&&Denominator<0)
                    sign = -1;
                var gcd = Math.Abs(Gcd.zadanie(Numerator, Denominator));
                this._numerator = sign*Numerator/gcd;
                this._denominator = sign*Denominator/gcd;
            }
            
        }

        public int Numerator { get { return this._numerator; } }
        public int Denominator { get { return this._denominator; } }

        public string Ratio()
        {
            return (Denominator == 1)?Numerator.ToString():Numerator.ToString() + "/" + Denominator.ToString();
        }
    }
}

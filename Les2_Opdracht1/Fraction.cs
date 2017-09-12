using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2_Opdracht1
{
    class Fraction
    {
        // num(erator) (teller) en (den)umerator(noemer):
        int num, den;

        public Fraction(int num, int den)
        {
            this.num = num;
            this.den = den;
        }

        // overload operator +  
        // all operator overload definitions should be: public static  
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            return a.num > b.den;
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            return a.num < b.den;
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.num == b.den;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return a.num != b.den;
        }

        public override bool Equals(object obj)
        {
            var fraction = obj as Fraction;
            return fraction != null &&
                   num == fraction.num &&
                   den == fraction.den;
        }

        /*
        public static explicit operator Fraction(int)
        {
            return (int) 0; //TODO
        }*/

        // overload operator *
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.num, a.den * b.den);
        }

        // user-defined conversion from Fraction to double
        //  In general, implicit conversion operators should:
        //	- never throw exceptions and 
        //	- never lose information
        public static implicit operator double(Fraction f)
        {
            return (double)f.num / f.den;
        }

        public override string ToString()
        {
            return string.Format($"({num} / {den})");
        }
    }
}

using System;

namespace myFraction
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            numerator = a;
            denominator = b;
            Simplify();
        }

        public static Fraction operator +(Fraction obj1, Fraction obj2)
        {
            int commonDenominator = obj1.denominator * obj2.denominator;
            int newNumerator = obj1.numerator * obj2.denominator + obj2.numerator * obj1.denominator;
            return new Fraction(newNumerator, commonDenominator);
        }

        public static Fraction operator -(Fraction obj1, Fraction obj2)
        {
            int commonDenominator = obj1.denominator * obj2.denominator;
            int newNumerator = obj1.numerator * obj2.denominator - obj2.numerator * obj1.denominator;
            return new Fraction(newNumerator, commonDenominator);
        }

        public static Fraction operator *(Fraction obj1, Fraction obj2)
        {
            int newDenominator = obj1.denominator * obj2.denominator;
            int newNumerator = obj1.numerator * obj2.numerator;
            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction operator /(Fraction obj1, Fraction obj2)
        {
            if (obj2.numerator == 0)
            {
                throw new DivideByZeroException("Cannot divide by a fraction with a numerator of zero.");
            }
            int newDenominator = obj1.denominator * obj2.numerator;
            int newNumerator = obj1.numerator * obj2.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        private void Simplify()
        {
            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        public void Print()
        {
            Console.WriteLine($"{numerator}/{denominator}");
        }
    }
}

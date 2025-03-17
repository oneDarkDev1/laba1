using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    // Constructor
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

    // Overloading the + operator
    public static Fraction operator +(Fraction obj1, Fraction obj2)
    {
        int commonDenominator = obj1.denominator * obj2.denominator;
        int newNumerator = obj1.numerator * obj2.denominator + obj2.numerator * obj1.denominator;
        return new Fraction(newNumerator, commonDenominator);
    }

    // Simplify the fraction
    private void Simplify()
    {
        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;
    }

    // Greatest Common Divisor function
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

    // Print fraction
    public void Print()
    {
        Console.WriteLine($"{numerator}/{denominator}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter numerator of first fraction: ");
        int numerator1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter denominator of first fraction: ");
        int denominator1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter numerator of second fraction: ");
        int numerator2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter denominator of second fraction: ");
        int denominator2 = Convert.ToInt32(Console.ReadLine());

        Fraction firstFraction = new Fraction(numerator1, denominator1);
        Fraction secondFraction = new Fraction(numerator2, denominator2);
        
        Fraction result = firstFraction + secondFraction;

        Console.Write("Sum: ");
        result.Print();
    }
}

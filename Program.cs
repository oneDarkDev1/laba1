// using System;

// public class Fraction
// {
//     private int numerator;
//     private int denominator;

    
//     public Fraction(int a, int b)
//     {
//         if (b == 0)
//         {
//             throw new ArgumentException("Denominator cannot be zero.");
//         }
//         numerator = a;
//         denominator = b;
//         Simplify();
//     }

    
//     public static Fraction operator +(Fraction obj1, Fraction obj2)
//     {
//         int commonDenominator = obj1.denominator * obj2.denominator;
//         int newNumerator = obj1.numerator * obj2.denominator + obj2.numerator * obj1.denominator;
//         return new Fraction(newNumerator, commonDenominator);
//     }

//     public static Fraction operator -(Fraction obj1, Fraction obj2){
//         int commonDenominator = obj1.denominator * obj2.denominator;
//         int newNumerator = obj1.numerator * obj2.denominator - obj2.numerator * obj1.denominator;
//         return new Fraction(newNumerator, commonDenominator);
//     }

//     public static Fraction operator *(Fraction obj1, Fraction obj2){
//         int newDenominator = obj1.denominator * obj2.denominator;
//         int newNumerator = obj1.numerator * obj2.numerator;
//         return new Fraction(newNumerator, newDenominator);
//     }

//     public static Fraction operator /(Fraction obj1, Fraction obj2){
//         int newDenominator = obj1.denominator * obj2.numerator;
//         int newNumerator = obj1.numerator * obj2.denominator;
//         return new Fraction(newNumerator, newDenominator);
//     }


//     private void Simplify()
//     {
//         int gcd = GCD(numerator, denominator);
//         numerator /= gcd;
//         denominator /= gcd;
//     }

//     // Greatest Common Divisor function
//     private static int GCD(int a, int b)
//     {
//         while (b != 0)
//         {
//             int temp = b;
//             b = a % b;
//             a = temp;
//         }
//         return Math.Abs(a);
//     }


//     public void Print()
//     {
//         Console.WriteLine($"{numerator}/{denominator}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter numerator of first fraction: ");
//         int numerator1 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Enter denominator of first fraction: ");
//         int denominator1 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Enter numerator of second fraction: ");
//         int numerator2 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Enter denominator of second fraction: ");
//         int denominator2 = Convert.ToInt32(Console.ReadLine());

//         Fraction firstFraction = new Fraction(numerator1, denominator1);
//         Fraction secondFraction = new Fraction(numerator2, denominator2);
        
//         Console.Write("Enter operation (+, -, *, /): ");
//         string operation = Console.ReadLine();

//         if (operation == "+")
//         {
//             Fraction result = firstFraction + secondFraction;
//             Console.Write("Sum: ");
//             result.Print();
//         }

//         if (operation == "-")
//         {
//             Fraction result2 = firstFraction - secondFraction;
//             Console.WriteLine("Difference: ");
//             result2.Print();
//         }

//         if (operation == "*")
//         {
//             Fraction result3 = firstFraction * secondFraction;
//             Console.WriteLine("Multiply: ");
//             result3.Print();
//         }
        
//         if (operation == "/")
//         {
//             Fraction result4 = firstFraction / secondFraction;
//             Console.WriteLine("Devison: ");
//             result4.Print();
//         }
        

//     }
// }



// using System;
// using System.Globalization;
// using System.Text;


// IDatePrinter printer = new EuropeanDatePrinter();
// Console.WriteLine("European: " + printer.Print());
// printer = new AmericanDatePrinter();
// Console.WriteLine("American: " + printer.Print());

// // Использование декораторов
// IDatePrinter decoratedPrinter = new BracketsDecorator(new EuropeanDatePrinter());
// Console.WriteLine("Brackets European: " + decoratedPrinter.Print());

// decoratedPrinter = new StarsDecorator(new BracketsDecorator(new AmericanDatePrinter()));
// Console.WriteLine("Stars + Brackets American: " + decoratedPrinter.Print());

// // Произвольное комбинирование
// decoratedPrinter = new BracketsDecorator(new StarsDecorator(new EuropeanDatePrinter()));
// Console.WriteLine("Brackets + Stars European: " + decoratedPrinter.Print());




// public interface IDatePrinter
// {
//     string Print();
// }

// public class EuropeanDatePrinter : IDatePrinter
// {
//     public string Print()
//     {
//         return DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss", CultureInfo.GetCultureInfo("fr-FR"));
//     }
// }

// public class AmericanDatePrinter : IDatePrinter
// {
//     public string Print()
//     {
//         return DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt", CultureInfo.GetCultureInfo("en-US"));
//     }
// }

// public abstract class DateDecorator : IDatePrinter
// {
//     protected IDatePrinter _datePrinter;

//     public DateDecorator(IDatePrinter datePrinter)
//     {
//         _datePrinter = datePrinter;
//     }

//     public abstract string Print();
// }



// public class BracketsDecorator : DateDecorator
// {
//     public BracketsDecorator(IDatePrinter datePrinter) : base(datePrinter) { }

//     public override string Print()
//     {
//         StringBuilder sb = new StringBuilder();
//         sb.Append("[ ");
//         sb.Append(_datePrinter.Print());
//         sb.Append(" ]");
//         return sb.ToString();
//     }
// }

// public class StarsDecorator : DateDecorator
// {
//     public StarsDecorator(IDatePrinter datePrinter) : base(datePrinter) { }

//     public override string Print()
//     {
//         StringBuilder sb = new StringBuilder();
//         sb.Append("*** ");
//         sb.Append(_datePrinter.Print());
//         sb.Append(" ***");
//         return sb.ToString();
//     }
// }



using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Создание узлов
        TreeNode<string> root = new TreeNode<string>("Root");
        TreeNode<string> child1 = new TreeNode<string>("Child 1");
        TreeNode<string> child2 = new TreeNode<string>("Child 2");
        TreeNode<string> grandChild1 = new TreeNode<string>("Grandchild 1");
        TreeNode<string> grandChild2 = new TreeNode<string>("Grandchild 2");

        // Формирование дерева
        root.AddChild(child1);
        root.AddChild(child2);
        child1.AddChild(grandChild1);
        child2.AddChild(grandChild2);

        // Вывод структуры дерева
        root.PrintTree();
    }
}


public class TreeNode<T>
{
    public T Value { get; set; } 
    public List<TreeNode<T>> Children { get; set; } 

    public TreeNode(T value)
    {
        Value = value;
        Children = new List<TreeNode<T>>();
    }

    public void AddChild(TreeNode<T> child)
    {
        Children.Add(child);
    }

    // Рекурсивный вывод всех потомков
    public void PrintTree(string indent = "")
    {
        Console.WriteLine(indent + Value);
        foreach (var child in Children)
        {
            child.PrintTree(indent + "  ");
        }
    }
}





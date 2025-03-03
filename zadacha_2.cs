// using System;
// using System.Globalization;
// using System.Text;

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



// class Program
// {
//     static void Main()
//     {
//         IDatePrinter printer = new EuropeanDatePrinter();
//         Console.WriteLine("European: " + printer.Print());

//         printer = new AmericanDatePrinter();
//         Console.WriteLine("American: " + printer.Print());

//         // Использование декораторов
//         IDatePrinter decoratedPrinter = new BracketsDecorator(new EuropeanDatePrinter());
//         Console.WriteLine("Brackets European: " + decoratedPrinter.Print());

//         decoratedPrinter = new StarsDecorator(new BracketsDecorator(new AmericanDatePrinter()));
//         Console.WriteLine("Stars + Brackets American: " + decoratedPrinter.Print());

//         // Произвольное комбинирование
//         decoratedPrinter = new BracketsDecorator(new StarsDecorator(new EuropeanDatePrinter()));
//         Console.WriteLine("Brackets + Stars European: " + decoratedPrinter.Print());
//     }
// }

// using System;
// using System.Globalization;
// using System.Text;
// using zadacha2;

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

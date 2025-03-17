// using System;
// using myFraction;


// class Program{
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

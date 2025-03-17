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







// using System;
// using System.Collections.Generic;


// class Program
// {
//     static void Main()
//     {
//         // Создание узлов
//         TreeNode<string> root = new TreeNode<string>("Root");
//         TreeNode<string> child1 = new TreeNode<string>("Child 1");
//         TreeNode<string> child2 = new TreeNode<string>("Child 2");
//         TreeNode<string> grandChild1 = new TreeNode<string>("Grandchild 1");
//         TreeNode<string> grandChild2 = new TreeNode<string>("Grandchild 2");

//         // Формирование дерева
//         root.AddChild(child1);
//         root.AddChild(child2);
//         child1.AddChild(grandChild1);
//         child2.AddChild(grandChild2);

//         // Вывод структуры дерева
//         root.PrintTree();
//     }
// }


// public class TreeNode<T>
// {
//     public T Value { get; set; } 
//     public List<TreeNode<T>> Children { get; set; } 

//     public TreeNode(T value)
//     {
//         Value = value;
//         Children = new List<TreeNode<T>>();
//     }

//     public void AddChild(TreeNode<T> child)
//     {
//         Children.Add(child);
//     }

//     // Рекурсивный вывод всех потомков
//     public void PrintTree(string indent = "")
//     {
//         Console.WriteLine(indent + Value);
//         foreach (var child in Children)
//         {
//             child.PrintTree(indent + "  ");
//         }
//     }
// }





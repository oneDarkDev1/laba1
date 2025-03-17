using System;
using System.Collections.Generic;
using TN;

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

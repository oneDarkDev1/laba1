namespace TN{
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
}

namespace DataStructures.BinaryTree;

public class BinaryTreeNode<T>: IComparable<T>
where T : IComparable<T>
{
    //props
    public T Data;
    public BinaryTreeNode<T>? Left;
    public BinaryTreeNode<T>? Right;
    // constructors
    public BinaryTreeNode(T value)
    {
        Data = value;
    }

    public int CompareTo(T? other)
    {
        return Data.CompareTo(other);
    }

    // methods


}

namespace DataStructures.BinaryTree;

public class BinaryTree<T> where T : IComparable<T>
{
    private BinaryTreeNode<T> Root { get; set; }
    public int Count { get; private set; }


    #region Add Nodes

    public void Add(T value)
    {
        Add(new BinaryTreeNode<T>(value));
    }

    public void Add(BinaryTreeNode<T> newNode)
    {
        // not empty so start recursions to look for the node to insert to 
        if (Root != null) AddToNode(Root, newNode);
        else Root = newNode;

        Count++;
    }

    private void AddToNode(BinaryTreeNode<T> target, BinaryTreeNode<T> newNode)
    {
        // gives -1 if newnode is smaller 
        if (target.Data.CompareTo(newNode.Data) > 0)
        {
            if (target.Left == null) target.Left = newNode;
            else AddToNode(target.Left, newNode);

        }
        else // if the newnode is larger or equal
        {
            if (target.Right == null)
            {
                target.Right = newNode;
            }
            else
            {
                AddToNode(target.Right, newNode);

            }
        }
    }

    #endregion

    #region Finds

    public bool Contains(T value)
    {
        return Contains(new BinaryTreeNode<T>(value));
    }

    public bool Contains(BinaryTreeNode<T> nodeToFind)
    {
        return FindWithParent(nodeToFind).parentNode != null;
    }

    private (BinaryTreeNode<T>? foundNode, BinaryTreeNode<T>? parentNode) FindWithParent(BinaryTreeNode<T> nodeToFind)
    {
        var current = Root;
        BinaryTreeNode<T>? parent = null;
        while (current != null)
        {
            var result = current.Data.CompareTo(nodeToFind.Data);
            // nodetofind is less than current , go left!
            if (result > 0)
            {
                parent = current;
                current = current.Left;
            }
            // nodetofind is more than current , go right!
            else if (result < 0)
            {
                parent = current;
                current = current.Right;
            }
            else
            {
                // result == 0 we have a match
                break;
            }
        }
        return (current, parent);
    }

    #endregion

}

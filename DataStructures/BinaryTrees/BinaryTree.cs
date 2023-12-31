using System.Collections;

namespace DataStructures.BinaryTree;

public class BinaryTree<T> 
where T : IComparable<T>
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


    /// <summary>
    /// Finds a node in the binary tree along with its parent node.
    /// </summary>
    /// <param name="nodeToFind">The node to find in the tree.</param>
    /// <returns>
    /// A tuple with two elements:
    ///   - The found node (<see cref="BinaryTreeNode{T}"/>).
    ///   - The parent node (<see cref="BinaryTreeNode{T}"/>).
    /// If the node is not found, both values will be null.
    /// </returns>
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

    #region Remove


    public bool RemoveNode(T value)
    {
        return RemoveNode(new BinaryTreeNode<T>(value));
    }

    public bool RemoveNode(BinaryTreeNode<T> noteToRemove)
    {
        var (current, parent) = FindWithParent(noteToRemove);
        // if not found return false indicating it was not removed
        if (current == null)
        {
            return false;
        }

        Count--;
        // Case 1: current has no children at all. 
        // set the parents reference of current to null
        if (current.Left == null && current.Right == null)
        {
            if (parent.Right == current)
            {
                parent.Right = null;
            }
            else
            {
                parent.Left = null;
            }
            return true;
        }

        // Case 2: current has 1 child 
        //has a left child only
        if (current.Left != null && current.Right == null)
        {
            return RemoveNodeWithOneChild(current, parent);
        }
        // has a right child only 
        else if (current.Left == null && current.Right != null)
        {
            return RemoveNodeWithOneChild(current, parent);
        }

        // Case 3: current has 2 children
        // I choose to go with the MINIMUM IN RIGHT SUB TREE
        if (current.Left != null && current.Right != null)
        {
            // step 1 : find minimum in the right side of the subtree
            BinaryTreeNode<T> leftmostOfRightSubtree = current.Left;
            BinaryTreeNode<T> leftmostOfRightSubtreeParent = current;

            while (leftmostOfRightSubtree.Left != null)
            {
                // when there is no more left nodes this is the Smallest node 
                leftmostOfRightSubtreeParent = leftmostOfRightSubtree;
                leftmostOfRightSubtree = leftmostOfRightSubtree.Left;
            }
            // move the leftmosts value to the current (to be deleted node)
            current.Data = leftmostOfRightSubtree.Data;
            // we need to see what to do with the leftmosts node connections 
            // it can only have the following 
            // a. a right child 
            // b. no children 
            if (leftmostOfRightSubtree.Right != null)
            {
                // has a right child 
                current.Right = leftmostOfRightSubtree.Right;
                return true;
            }
            else
            {
                // b. no children
                leftmostOfRightSubtreeParent.Left = null;
                return true;
            }
        }
        return false;
    }

    private bool RemoveNodeWithOneChild(BinaryTreeNode<T> current, BinaryTreeNode<T>? parent)
    {
        BinaryTreeNode<T> currentChild = current.Left == null ? current.Right : current.Left;
        // step 2 find if current is left or right child and replace with it's child 
        if (parent == null)
        {
            Root = currentChild;
            return true;
        }
        int result = parent.Data.CompareTo(current.Data);
        if (result > 0) // current was on the left
        {
            parent.Left = currentChild;
            return true;
        }
        else // current was on the right
        {
            parent.Right = currentChild;
            return true;
        }
    }


    #endregion

    #region Traversals
    // there are three types
    // pre/in/post order traversal

    public void PreOrderTraversal(Action<T> action)
    {
        PreOrderTraversal(action, Root);
    }

    private void PreOrderTraversal(Action<T> action, BinaryTreeNode<T> node)
    {
        if (node != null)
        {
            action(node.Data);
            PreOrderTraversal(action, node.Left);
            PreOrderTraversal(action, node.Right);
        }

    }
    public void InOrderTraversal(Action<T> action)
    {
        InOrderTraversal(action, Root);
    }

    private void InOrderTraversal(Action<T> action, BinaryTreeNode<T> node)
    {
        if (node != null)
        {
            InOrderTraversal(action, node.Left);
            action(node.Data);
            InOrderTraversal(action, node.Right);
        }

    }
    public void PostOrderTraversal(Action<T> action)
    {
        PostOrderTraversal(action, Root);
    }

    private void PostOrderTraversal(Action<T> action, BinaryTreeNode<T> node)
    {
        if (node != null)
        {
            PostOrderTraversal(action, node.Left);
            PostOrderTraversal(action, node.Right);
            action(node.Data);
        }

    }
    #endregion
}

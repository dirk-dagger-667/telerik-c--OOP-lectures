using System;

//Define the data structure binary search tree with operations for "adding new element", "searching element" and "deleting elements". It is not necessary to keep the tree balanced. Implement the standard methods from System.Object – ToString(), Equals(…), GetHashCode() and the operators for comparison  == and !=. Add and implement the ICloneable interface for deep copy of the tree. Remark: Use two types – structure BinarySearchTree (for the tree) and class TreeNode (for the tree elements). Implement IEnumerable<T> to traverse the tree.

public class BinarySearchTree<T> where T : IComparable<T>
{
    private BinaryTreeNode<T> root;

    public BinarySearchTree()
    {
        this.root = null;
    }

    public void Insert(T value)
    {
        this.root = Insert(value, null, root);
    }

    private BinaryTreeNode<T> Insert(T value,
    BinaryTreeNode<T> parentNode, BinaryTreeNode<T> node)
    {
        if (node == null)
        {
            node = new BinaryTreeNode<T>(value);
            node.parent = parentNode;
        }
        else
        {
            int compareTo = value.CompareTo(node.value);

            if (compareTo < 0)
            {
                node.leftChild =
                Insert(value, node, node.leftChild);
            }
            else if (compareTo > 0)
            {
                node.rightChild =
                Insert(value, node, node.rightChild);
            }
        }
        return node;
    }

    private BinaryTreeNode<T> Find(T value)
    {
        BinaryTreeNode<T> node = this.root;
        while (node != null)
        {
            int compareTo = value.CompareTo(node.value);
            if (compareTo < 0)
            {
                node = node.leftChild;
            }
            else if (compareTo > 0)
            {
                node = node.rightChild;
            }
            else
            {
                break;
            }
        }
        return node;
    }

    public bool Contains(T value)
    {
        bool found = this.Find(value) != null;
        return found;
    }

    public void Remove(T value)
    {
        BinaryTreeNode<T> nodeToDelete = Find(value);
        if (nodeToDelete != null)
        {
            Remove(nodeToDelete);
        }
    }

    private void Remove(BinaryTreeNode<T> node)
    {
        if (node.leftChild != null && node.rightChild != null)
        {
            BinaryTreeNode<T> replacement = node.rightChild;
            while (replacement.leftChild != null)
            {
                replacement = replacement.leftChild;
            }
            node.value = replacement.value;
            node = replacement;
        }

        BinaryTreeNode<T> theChild = node.leftChild != null ?
        node.leftChild : node.rightChild;

        if (theChild != null)
        {
            theChild.parent = node.parent;
            if (node.parent == null)
            {
                root = theChild;
            }
            else
            {
                if (node.parent.leftChild == node)
                {
                    node.parent.leftChild = theChild;
                }
                else
                {
                    node.parent.rightChild = theChild;
                }
            }
        }
        else
        {
            if (node.parent == null)
            {
                root = null;
            }
            else
            {
                if (node.parent.leftChild == node)
                {
                    node.parent.leftChild = null;
                }
                else
                {
                    node.parent.rightChild = null;
                }
            }
        }
    }

    public void PrintTreeDFS()
    {
        PrintTreeDFS(this.root);
        Console.WriteLine();
    }

    private void PrintTreeDFS(BinaryTreeNode<T> node)
    {
        if (node != null)
        {
            PrintTreeDFS(node.leftChild);
            Console.Write(node.value + " ");
            PrintTreeDFS(node.rightChild);
        }
    }
}

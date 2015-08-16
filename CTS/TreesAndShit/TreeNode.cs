using System;

internal class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>> 
    where T : IComparable<T>
{
    internal T value;
    internal BinaryTreeNode<T> parent;
    internal BinaryTreeNode<T> leftChild;
    internal BinaryTreeNode<T> rightChild;

    public BinaryTreeNode(T value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("Cannot insert null value!");
        }

        this.value = value;
        this.parent = null;
        this.leftChild = null;
        this.rightChild = null;
    }
    public override string ToString()
    {
        return this.value.ToString();
    }
    public override int GetHashCode()
    {
        return this.value.GetHashCode();
    }
    public override bool Equals(object obj)
    {
        BinaryTreeNode<T> other = obj as BinaryTreeNode<T>;
        return this.CompareTo(other) == 0;
    }
    public int CompareTo(BinaryTreeNode<T> other)
    {
        return this.value.CompareTo(other.value);
    }
}

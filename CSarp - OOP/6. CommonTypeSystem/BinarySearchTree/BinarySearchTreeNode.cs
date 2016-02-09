namespace BinarySearchTree
{
    using System;

    internal class BinarySearchTreeNode<T>
    {
        private T value;

        private bool hasParent;

        private BinarySearchTreeNode<T> parent;

        private BinarySearchTreeNode<T> leftChild;

        private BinarySearchTreeNode<T> rightChild;

        public BinarySearchTreeNode(T val,BinarySearchTreeNode<T> parent, BinarySearchTreeNode<T> left, BinarySearchTreeNode<T> right)
        {
            this.Value = val;
            this.LeftChild = left;
            this.RightChild = right;
            this.Parent = parent;
        }

        public BinarySearchTreeNode(T val) : this(val, null, null, null)
        { }

        public BinarySearchTreeNode<T> Parent
        {
            get
            {
                return this.parent;
            }

            set
            {
                if (value == null)
                {
                    return;
                }
            }
        }

        public T Value
        {
            get
            {
                return this.value;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot insert null value");
                }
            }
        }

        public BinarySearchTreeNode<T> LeftChild
        {
            get
            {
                return this.leftChild;
            }

            set
            {
                if (value == null)
                {
                    return;
                }
            }
        }

        public BinarySearchTreeNode<T> RightChild
        {
            get
            {
                return this.rightChild;
            }

            set
            {
                if (value == null)
                {
                    return;
                }
            }
        }
    }
}
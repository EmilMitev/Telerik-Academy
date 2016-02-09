// not entirely implemented, if you're reading this it means i haven't finished it.
namespace BinarySearchTree
{
    using System;

    internal class BinarySearchTree<T>
    {
        private BinarySearchTreeNode<T> root;

        public BinarySearchTree(T value, BinarySearchTree<T> leftTree, BinarySearchTree<T> rightTree)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null values.");
            }

            BinarySearchTreeNode<T> leftChild =
                leftTree != null ? leftTree.root : null;

            BinarySearchTreeNode<T> rigthChild =
                rightTree != null ? rightTree.root : null;

            this.root = new BinarySearchTreeNode<T>(value, leftChild, rigthChild, null);
        }

        public BinarySearchTree(T value)
            : this(value, null, null)
        {
        }

        public BinarySearchTreeNode<T> Root
        {
            get { return this.root; }
        }

        public bool AddLeftElement(T value)
        {
            BinarySearchTreeNode<T> leftNew = new BinarySearchTreeNode<T>(value);

            leftNew.Parent = this.Root;

            return true;
        }
    }
}
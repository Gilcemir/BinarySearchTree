using System;

namespace Tree
{
    public class TreeNode<T>
        where T : IComparable
    {
        public T val { get; set;}
        public TreeNode<T> left { get; set;}
        public TreeNode<T> right { get; set;}

        public TreeNode(T val = default(T), TreeNode<T> left = null, TreeNode<T> right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class BinarySearchTree<T>
        where T : IComparable
    {
        public TreeNode<T> root { get; set;}
        public int Count {get;}
        
        public BinarySearchTree()
        {
            root = null;
            Count = 0;
        }


    }
}

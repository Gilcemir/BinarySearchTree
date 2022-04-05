using System;

namespace Tree
{
    public class TreeNode<T>
        where T : IComparable, IEquatable<T>
    {
        public T val { get; set;}
        public TreeNode<T> left { get; set;}
        public TreeNode<T> right { get; set;}
        public int Count {get; set;}
        public TreeNode(T val = default(T))
        {
            this.val = val;
            Count = 1;
        }
    }

    public class BinarySearchTree<T>
        where T : IComparable, IEquatable<T>
    {
        public TreeNode<T> root { get; set;}
        public int Count {get;}
        
        public BinarySearchTree()
        {
            root = null;
            Count = 0;
        }

        public BinarySearchTree(IList<T> list){

        }

        public BinarySearchTree(T[] list)
        {
            
        }

        public BinarySearchTree(T elem)
        {
            
        }
        public bool Search(T target){

        }

        public bool Insert(T elem){

        }

        public bool Delete(T elem){

        }
    }
}

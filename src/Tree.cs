using System;
using System.Collections.Generic;

namespace Tree
{
    public class TreeNode<T>
        where T : IComparable, IEquatable<T>
    {
        public T val { get; set;}
        public TreeNode<T> left { get; set;}
        public TreeNode<T> right { get; set;}
        public int Count {get; set;}
        public TreeNode(T val = default(T), TreeNode<T> left = null, TreeNode<T> right = null)
        {
            this.val = val;
            this.Count = 1;
            this.left = left;
            this.right = right;
        }
    }

    public class BinarySearchTree<T>
        where T : IComparable, IEquatable<T>
    {
        public TreeNode<T> _root { get; set;}
        private int Count {get; set;}
        
        public BinarySearchTree()
        {
            _root = null;
            Count = 0;
        }

        public BinarySearchTree(IList<T> list){

        }

        public BinarySearchTree(T[] list)
        {
            
        }

        public BinarySearchTree(T elem)
        {
            _root = new TreeNode<T>(elem);
            Count = 1;
        }
        public int Length(){
            return Count;
        }
        public bool Search(T target){
            TreeNode<T> node = Find(_root, target);
            if(node == null){
                Console.WriteLine("Element is not present in the BST");
                return false;
            }
            Console.WriteLine($"Element {node.val} has {node.Count} occurrenc{(node.Count == 1? "y":"es")} in the BST");
            return true;
        }

        private TreeNode<T> Find(TreeNode<T> root, T target){
            if(root == null)
                return null;
            if(root.val.CompareTo(target) == 1){ // root.val > elem
                return Find(root.left, target);
            }else if(root.val.CompareTo(target) == -1){ //root.val < elem
                return Find(root.right, target);
            }else{// root.val == elem
                return root;
            }
        }
        public bool Insert(T elem){
            _root = Add(_root, elem);
            Count++;
            return true;
        }
        private TreeNode<T> Add(TreeNode<T> root, T elem){
            if(root == null){
                return new TreeNode<T>(elem);
            }
            if(root.val.CompareTo(elem) == 1){ // root.val > elem
                root.left = Add(root.left, elem);
            }else if(root.val.CompareTo(elem) == -1){ //root.val < elem
                root.right = Add(root.right, elem);
            }else{// root.val == elem
                root.Count++;
            }   
            return root;
        }

        public bool Delete(T elem){
            return true;
        }

        public void Print(){
            Queue<TreeNode<T>> q = new Queue<TreeNode<T>>();

            if(_root == null){ //empty tree
                Console.WriteLine("Empty Tree");
                    return;
            }
            q.Enqueue(_root);
            while(q.Count > 0){
                int size = q.Count;
                for(int i = 0; i < size; i++){
                    TreeNode<T> cur = q.Dequeue();
                    Console.Write($"{cur.val}({cur.Count}) ");

                    if(cur.left != null){
                        q.Enqueue(cur.left);
                    }
                    if(cur.right != null){
                        q.Enqueue(cur.right);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

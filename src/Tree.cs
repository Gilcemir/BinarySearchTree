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
        private TreeNode<T> _root { get; set;}
        private int Count {get; set;}
        
        public BinarySearchTree()
        {
            _root = null;
            Count = 0;
        }

        public BinarySearchTree(IList<T> list)
        {
            Count = 0;
            foreach(T item in list){
                Insert(item);
            }
        }

        public BinarySearchTree(T[] list)
        {
            Count = 0;
            foreach(T item in list){
                Insert(item);
            }
        }

        public BinarySearchTree(T elem)
        {
            Count = 0;
            Insert(elem);
        }
        public int Length(){
            return Count;
        }

        public int Height(){
            return Depth(_root);
        }

        private int Depth(TreeNode<T> root){
            if(root == null)
                return 0;

            return 1 + Math.Max(Depth(root.left), Depth(root.right));
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
            int prevCount = Count;
            _root = DeleteNode(_root, elem);
            return Count != prevCount;
        }

        private TreeNode<T> DeleteNode(TreeNode<T> root, T elem){
            if(root == null)
                return null;
            
            if(root.val.CompareTo(elem) == 1) //root.val > elem
            {
                root.left = DeleteNode(root.left, elem);
            }else if(root.val.CompareTo(elem) == -1) //root.val < elem
            {
                root.right =  DeleteNode(root.right, elem);
            }else
            {
                if(root.Count > 1){
                    root.Count--;
                    Count--;
                }else{
                    if(root.right == null && root.left == null) //if its a leaf
                    {
                        root = null;
                        Count--;
                    }else if(root.right == null)
                    {
                        root = root.left;
                        Count--;
                    }
                    else if(root.left == null)
                    {
                        root = root.right;
                        Count--;
                    }else{
                        TreeNode<T> temp = FindMin(root.right); //find min in the right subtree(with higher values)
                        root.val = temp.val; //swap values
                        root.Count = temp.Count;//swap values
                        temp = Find(root.right, root.val); //find the root which was swapped
                        temp.Count = 1;//set count to 1, so this TreeNode will be deleted (not decreased in case there's more than one occurrency)
                        root.right = DeleteNode(root.right, root.val); //delete the node that was swapped.

                        //notice that here we dont decrease Count, since we have a recursive call in the last line in this block
                        // so this call will decrease its counting.
                    } 
                }
            }
            return root;
        }

        private TreeNode<T> FindMin(TreeNode<T> root){
            if(root.left == null){
                return root;
            }
            return FindMin(root.left);
        }

        public List<T> ToList(){
            List<TreeNode<T>> treeNodeList = new List<TreeNode<T>>();
            List<T> list = new List<T>();
            
            InorderTraversal(_root, treeNodeList);

            foreach(TreeNode<T> node in treeNodeList){
                for(int i = 0; i < node.Count; i++)
                    list.Add(node.val);
            }
            return list;
        }

        private void InorderTraversal(TreeNode<T> root, List<TreeNode<T>> list){
            if(root == null)
                return;
            
            InorderTraversal(root.left, list);
            list.Add(root);
            InorderTraversal(root.right, list);
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

                    if(cur.left != null)
                        q.Enqueue(cur.left);
                    
                    if(cur.right != null)
                        q.Enqueue(cur.right);
                }
                Console.WriteLine();
            }
        }
    }
}

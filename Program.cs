using Tree;
using System;

BinarySearchTree<int> BST = new BinarySearchTree<int>();
BST.Insert(5);
Console.WriteLine(BST._root.val);

BST.Insert(4);
BST.Insert(3);
BST.Insert(8);
BST.Insert(10);
BST.Insert(15);
BST.Insert(5);
BST.Insert(15);
BST.Insert(15);
BST.Insert(8);
BST.Insert(2);
BST.Insert(16);
BST.Insert(7);

BST.Print();

BST.Search(15);
BST.Search(4);
BST.Search(11);


Console.WriteLine($"Length of the Tree = {BST.Length()}");
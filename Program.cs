using Tree;
using System;

TreeNode<int> nodo = new TreeNode<int>();

nodo.right = new TreeNode<int>(1);
nodo.left = new TreeNode<int>(2);

Console.WriteLine("----");
Console.WriteLine(nodo.val);
Console.WriteLine(nodo.left.val);
Console.WriteLine(nodo.right.val);

Console.WriteLine($"left>right? = {nodo.left.val >nodo.right.val}");
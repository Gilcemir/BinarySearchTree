using Tree;
using System;

int[] arr = new int[]{5, 6, 12, 3, 5, 4, 7, 8, 65, 2, 12, 4};

List<int> list = new List<int>();
Random rd = new Random();
    for(int i = 0; i< 100000; i++){
   int rand_num = rd.Next(1,10000);
      list.Add(rand_num);
    }
BinarySearchTree<int> BST = new BinarySearchTree<int>(list);


BST.Print();

int toFind = Int32.Parse(Console.ReadLine());

bool found = BST.Search(toFind);
if(found)
    Console.WriteLine("found");
else
    Console.WriteLine("not found");
    
Console.WriteLine($"Number of Nodes in the Tree = {BST.Length()}");
Console.WriteLine($"Height of the Tree = {BST.Height()}");

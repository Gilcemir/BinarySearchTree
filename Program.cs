using Tree;
using System;

int[] arr = new int[]{5, 6, 12, 3, 5, 4, 7, 8, 65, 2, 12, 4};

List<int> list = new List<int>();
Random rd = new Random();
    for(int i = 0; i< 8; i++){
   int rand_num = rd.Next(1,25);
      list.Add(rand_num);
    }
BinarySearchTree<int> BST = new BinarySearchTree<int>(list);


BST.Print();


    
Console.WriteLine($"Number of Nodes in the Tree = {BST.Length()}");
Console.WriteLine($"Height of the Tree = {BST.Height()}");
Console.WriteLine();
Console.WriteLine("Enter the value to search: ");
int toFind = Int32.Parse(Console.ReadLine());

bool found = BST.Search(toFind);

Console.WriteLine();
Console.WriteLine($@"Enter the value to Delete: (x to exit!)");
string opt = Console.ReadLine().ToLower(); 
while( opt != "x"){
    int toDelete = Int32.Parse(opt);
    bool deleted = BST.Delete(toDelete);

BST.Print();

Console.WriteLine($"Number of Nodes in the Tree = {BST.Length()}");
Console.WriteLine($"Height of the Tree = {BST.Height()}");

Console.WriteLine($@"Enter the value to Delete: (x to exit!)");
opt = Console.ReadLine().ToLower();
Console.WriteLine();
}

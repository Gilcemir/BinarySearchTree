using Tree;
using System;

static BinarySearchTree<int> GenerateBST(int length, int maxValue)
{
    List<int> list = new List<int>();
    Random rd = new Random();
    for (int i = 0; i < length; i++)
    {
        int rand_num = rd.Next(1, maxValue);
        list.Add(rand_num);
    }
    return new BinarySearchTree<int>(list);
}

static string Menu()
{
    Console.WriteLine();
    Console.WriteLine(@"1 - Insert value: ");
    Console.WriteLine(@"2 - Delete value: ");
    Console.WriteLine(@"3 - Search value: ");
    Console.WriteLine(@"4 - Print BST using ToList() method: ");
    Console.WriteLine(@"5 - Current State of the Tree");
    Console.WriteLine(@"X - End program. ");
    Console.WriteLine();

    return Console.ReadLine().ToLower();
}

Console.WriteLine("Welcome to Binary Search Tree Generator.");
Console.WriteLine("For testing purpose, I will be testing with Type T = int. All the implementation in the Program.cs will be considering that statement.");
Console.WriteLine("Since this interface is only for testing purpose, I will not set boundries for the entries, or check either is valid or not.");


Console.WriteLine("\nEnter the Length of the Tree:");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("\nEnter the maximum value allowed for the Tree:");
int maxValue = int.Parse(Console.ReadLine());



BinarySearchTree<int> BST = GenerateBST(length, maxValue);


Console.WriteLine($"Current BST has length = {BST.Length()}, Height of {BST.Height()}");
Console.WriteLine("Visualization of the BST: ");
BST.Print();

string menu = Menu();
while (menu != "x")
{

    switch (menu)
    {
        case "1":
            Console.WriteLine("Enter the value to Insert: ");
            int toAdd = int.Parse(Console.ReadLine());
            BST.Insert(toAdd);
            break;
        case "2":
            Console.WriteLine("Enter the value to Delete: ");
            int toDelete = int.Parse(Console.ReadLine());
            if (BST.Delete(toDelete))
            {
                Console.WriteLine($"Element {toDelete} sucessfully deleted.");
            }
            else
            {
                Console.WriteLine($"Could not delete element {toDelete} in the Tree.");
            }
            break;
        case "3":
            Console.WriteLine("Enter the value to Insert: ");
            int toSearch = int.Parse(Console.ReadLine());
            if (BST.Search(toSearch))
            {
                Console.WriteLine($"Element {toSearch} sucessfully found in the Tree.");
            }
            else
            {
                Console.WriteLine($"Could not found element {toSearch} in the Tree.");
            }
            break;
        case "4":
            Console.WriteLine("Printing the Tree in order (In-order Traversal)");
            List<int> list = BST.ToList();
            foreach (int item in list)
                Console.Write(item + " ");
            Console.WriteLine();
            break;
        case "5":
            Console.WriteLine($"Current BST has length = {BST.Length()}, Height of {BST.Height()}");
            Console.WriteLine("Visualization of the BST: ");
            BST.Print();
            break;
        default:
            Console.WriteLine("Option not found.");
            break;
    }
    menu = Menu();
}



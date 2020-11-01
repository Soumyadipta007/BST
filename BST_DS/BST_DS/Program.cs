using System;

namespace BST_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            Console.WriteLine("Binary Search Tree -");
            binarySearchTree.Display();
        }
    }
}

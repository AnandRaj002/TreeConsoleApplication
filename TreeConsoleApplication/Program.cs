using System;

namespace TreeConsoleApplication
{    
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(int.MinValue);

            BinaryTree bTree = new BinaryTree();
            bTree.Root = new Node(10);
            
            //Console.WriteLine(bTree.Root._data);

            bTree.Root.leftChild = new Node(6);            
            bTree.Root.leftChild.leftChild = new Node(4);
            bTree.Root.leftChild.rightChild = new Node(7);
            bTree.Root.leftChild.leftChild.leftChild = new Node(2);
            bTree.Root.leftChild.leftChild.rightChild = new Node(5);

            bTree.Root.rightChild = new Node(12);
            bTree.Root.rightChild.leftChild = new Node(11);
            bTree.Root.rightChild.rightChild = new Node(13);

            Console.WriteLine("In Order Traversal : ");
            bTree.DisplayInOrder(bTree.Root);
            Console.WriteLine();

            Console.WriteLine("Pre Order Traversal : ");
            bTree.DisplayPreOrder(bTree.Root);
            Console.WriteLine();

            Console.WriteLine("Post Order Traversal : ");
            bTree.DisplayPostOrder(bTree.Root);
            Console.WriteLine();

            if (bTree.IsBinaySearchTree(bTree.Root, int.MinValue, int.MaxValue))
                Console.WriteLine("Is a Binary Search Tree");
            else
                Console.WriteLine("Not a Binary Search Tree");

            Console.WriteLine();
            Console.WriteLine();
            bTree.BFSDisplayTree(bTree.Root);
        }
    }
}

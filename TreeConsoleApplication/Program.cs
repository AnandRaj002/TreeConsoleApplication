using System;

namespace TreeConsoleApplication
{    
    class Program
    {
        static void Main(string[] args)
        {    
            BinaryTree bTree = new BinaryTree();
            bTree.Root = new Node(10);
            
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

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter Number of nodes for binary searh tree");

            var temp = Console.ReadLine();
            BinarySearchTree bst = new BinarySearchTree();

            for(int i = 0; i < Convert.ToInt32(temp); i++)
            {
                Console.WriteLine("Enter Node Data");
                //Insert Node Iterative
                //bst.InsertNode(new Node(Convert.ToInt32(Console.ReadLine())));
                bst.Root = bst.InsertNodeRecursive(bst.Root, Convert.ToInt32(Console.ReadLine()));
            }

            bTree.BFSDisplayTree(bst.Root);
            Console.WriteLine();
            if (bTree.IsBinaySearchTree(bst.Root, int.MinValue, int.MaxValue))
                Console.WriteLine("Is a Binary Search Tree");
            else
                Console.WriteLine("Not a Binary Search Tree");
        }
    }
}

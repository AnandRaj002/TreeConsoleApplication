using System;
using System.Collections.Generic;
using System.Text;

namespace TreeConsoleApplication
{
    /// <summary>
    /// Binary Tree is the tree with maximum two child.
    /// Binary Tree can or can not be BST (Binary Search Tree)
    /// </summary>
    public class BinaryTree
    {
        public Node Root { get; set; }

        public bool IsBinaySearchTree(Node node, int min, int max)
        {
            if (node == null)
                return true;

            if ((node._data < min) || (node._data > max))
                return false;

            return (IsBinaySearchTree(node.leftChild, min, node._data - 1) && IsBinaySearchTree(node.rightChild, node._data + 1, max));            
        }

        public int maxDepth(Node node)
        {
            if (node == null)
                return 0;
            else
            {
                int lDepth = maxDepth(node.leftChild);
                int rDepth = maxDepth(node.rightChild);

                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }

        public void BFSDisplayTree(Node root)
        {
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                var element = queue.Dequeue();

                Console.Write($"{element._data} ");

                if((element.leftChild != null) && (element.rightChild != null))
                {                    
                    queue.Enqueue(element.leftChild);
                    queue.Enqueue(element.rightChild);
                }
                else if(element.leftChild != null)
                {
                    queue.Enqueue(element.leftChild);
                }
                else if(element.rightChild != null)
                {
                    queue.Enqueue(element.rightChild);
                }                
            }
            //if(root != null)
            //{
            //    if (root == this.Root)
            //    {
            //        Console.WriteLine(root._data.ToString().PadLeft((maxDepth(root)*2)-1));
            //    }

            //    if (root.leftChild != null && root.rightChild != null)
            //    {
            //        //string test = "/" + "    " + "\\";
            //        //Console.WriteLine(test.PadLeft((maxDepth(root.rightChild) * 2) - 1)," ");
            //        Console.WriteLine(root.leftChild._data.ToString().PadLeft((maxDepth(root) * 2) - 1) + "    " + root.rightChild._data);
            //        DisplayTree(root.leftChild);
            //        DisplayTree(root.rightChild);
            //    }
            //    else if (root.leftChild != null)
            //    {
            //        Console.WriteLine("/");
            //        Console.WriteLine(root.leftChild._data);
            //        DisplayTree(root.leftChild);
            //    }
            //    else if(root.rightChild != null)
            //    {
            //        Console.WriteLine("\\");
            //        Console.WriteLine(root.rightChild._data);
            //        DisplayTree(root.rightChild);
            //    }                    
            //}
        }

        public void DisplayInOrder(Node root)
        {
            if (root != null)
            {
                DisplayInOrder(root.leftChild);
                Console.Write(root._data + " ");
                DisplayInOrder(root.rightChild);
            }
        }

        public void DisplayPreOrder(Node root)
        {
            if (root != null)
            {
                Console.Write(root._data + " ");
                DisplayPreOrder(root.leftChild);                
                DisplayPreOrder(root.rightChild);
            }
        }

        public void DisplayPostOrder(Node root)
        {
            if (root != null)
            {                
                DisplayPostOrder(root.leftChild);
                DisplayPostOrder(root.rightChild);
                Console.Write(root._data + " ");
            }
        }
    }
}

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

        /// <summary>
        /// Method check if the tree is BST (Binary Search Tree) or not
        /// Recirsive method
        /// Define min and max boundary and see if each node data in range of min and max value
        /// Reduce max value to input node - 1 for left sub tree
        /// Reduce min value to input node + 1 for rigth sub tree
        /// </summary>
        /// <param name="node">Input node/Root Node</param>
        /// <param name="min">minimum bondary value</param>
        /// <param name="max">maximum boundry value</param>
        /// <returns></returns>
        public bool IsBinaySearchTree(Node node, int min, int max)
        {
            if (node == null)
                return true;

            if ((node._data < min) || (node._data > max))
                return false;

            return (IsBinaySearchTree(node.leftChild, min, node._data - 1) && IsBinaySearchTree(node.rightChild, node._data + 1, max));            
        }

        /// <summary>
        /// Find Depth of tree at any node
        /// Recursive method
        /// Start with zero and increase depth on each left sub tree and right sub tree
        /// return whatever is greater value
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
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

        /// <summary>
        /// BFS Traversal using queue
        /// Enter root into queue
        /// Loop till queue is empty. Remove root, Print data and Insert all its child.
        /// </summary>
        /// <param name="root">Input Node/Root Node</param>
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
        }

        /// <summary>
        /// In Order Display
        /// Recursive Method
        /// Go to left sub tree -> Print Data -> GO to right sub tree
        /// </summary>
        /// <param name="root">Input Node/Root Node</param>
        public void DisplayInOrder(Node root)
        {
            if (root != null)
            {
                DisplayInOrder(root.leftChild);
                Console.Write(root._data + " ");
                DisplayInOrder(root.rightChild);
            }
        }

        /// <summary>
        /// Pre Order Display
        /// Recursive Method
        /// Print Data -> Got to left sub tree -> GO to right sub tree
        /// </summary>
        /// <param name="root">Input Node/Root Node</param>
        public void DisplayPreOrder(Node root)
        {
            if (root != null)
            {
                Console.Write(root._data + " ");
                DisplayPreOrder(root.leftChild);                
                DisplayPreOrder(root.rightChild);
            }
        }

        /// <summary>
        /// Post Order Display
        /// Recusive Method
        /// Go to left sub tree -> Go to right sub tree -> Print Data
        /// </summary>
        /// <param name="root">Input Node/Root Node</param>
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

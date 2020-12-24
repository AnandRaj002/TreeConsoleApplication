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

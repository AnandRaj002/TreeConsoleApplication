using System;
using System.Collections.Generic;
using System.Text;

namespace TreeConsoleApplication
{
    /// <summary>
    /// Binary Search Tree (BST) is ordered Binary tree
    /// Can have max two child
    /// Left Sub tree must be smaller than Root
    /// Right SUb tree must be bigger than Root
    /// </summary>
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Insert Node into BST - Iterative        
        /// </summary>
        /// <param name="node">Input Node</param>
        public void InsertNode(Node node)
        {
            if (node != null)
            {
                if (Root == null)
                    Root = node;
                else
                {
                    var temp = Root;
                    var pre = Root;

                    while(temp != null)
                    {
                        if(node._data > temp._data)
                        {
                            pre = temp;
                            temp = temp.rightChild;
                        }
                        else if(node._data < temp._data)
                        {
                            pre = temp;
                            temp = temp.leftChild;
                        }
                        else if(node._data == temp._data)
                        {
                            Console.WriteLine("Duplicate Node");
                            return;
                        }
                    }
                    
                    if(pre._data > node._data)
                    {
                        pre.leftChild = node;
                    }
                    else if(pre._data < node._data)
                    {
                        pre.rightChild = node;
                    }
                }
            }  
        }

        /// <summary>
        /// Insert Node int BST - Recursive
        /// </summary>
        /// <param name="node">Input/Root Node</param>
        /// <param name="data">Input Data</param>
        /// <returns>New node</returns>
        public Node InsertNodeRecursive(Node node,int data)
        {
            if (node == null)
            {
                node = new Node(data);
                return node;
            }
            else
            {
                if (data < node._data)
                    node.leftChild = InsertNodeRecursive(node.leftChild, data);
                else if (data > node._data)
                    node.rightChild = InsertNodeRecursive(node.rightChild, data);
                else if (data == node._data)
                    Console.WriteLine("Duplicate Node");
            }

            return node;
        }
    }
}

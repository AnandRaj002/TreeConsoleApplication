using System;
using System.Collections.Generic;
using System.Text;

namespace TreeConsoleApplication
{
    /// <summary>
    /// Tree Node Class
    /// Contains integer data value & Left and Right Child nodes    
    /// </summary>
    public class Node
    {
        public int _data;
        public Node leftChild, rightChild;

        public Node(int data)
        {
            this._data = data;
        }
    }
}

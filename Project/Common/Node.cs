using System;

namespace Common
{
    public class Node
    {
        public string Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node() { }
        public Node(string data, Node left, Node right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        public int Data { get; set; }
        public Node PNext { get; set; }

        public Node(int data)
        {
            Data = data;
            PNext = null;
        }

        public Node()
        {
        }

        public void InputData()
        {
            Data = int.Parse(Console.ReadLine());
            PNext = null;
        }

        public void DisplayNode()
        {
            Console.WriteLine($"Current data: {Data}");
        }
    }
}

namespace LinkedList
{
    internal class SingleLinkedList
    {
        public Node PHead { get; set; }
        public Node PTail { get; set; }

        public SingleLinkedList()
        {
            PHead = PTail = null;
        }

        public void AddNode(Node node)
        {
            if (PHead == null)
            {
                PHead = PTail = node;
            }
            else
            {
                PTail.PNext = node;
                PTail = node;
            }
        }
        public void InputLinkedList(int numNode)
        {
            for (int i = 0; i < numNode; i++)
            {
                Node p = new Node();
                p.InputData();
                AddNode(p);
            }
        }
        public void DisplayLinkedList()
        {
            for (Node i = PHead; i != null; i = i.PNext)
                i.DisplayNode();
        }
        public void RemoveFirstElement()
        {
            if (PHead == null)
                return;
            if (PHead.PNext == null) // 1 phan tu
            {
                PHead = PTail = null;
                return;
            }
            PHead = PHead.PNext;
        }
        public void RemoveLastElement()
        {
            if (PHead == null)
                return;
            if (PHead.PNext == null) // 1 phan tu
            {
                PHead = PTail = null;
                return;
            }
            Node p = PHead;
            for (; p.PNext != PTail; p = p.PNext) { }
            p.PNext = null;
            PTail = p;
        }
        public void RemoveAnyElement(int x)
        {
            if (PHead == null)
                return;

            if (PHead.Data == x)
            {
                RemoveFirstElement();
                return;
            }
            else if (PTail.Data == x)
            {
                RemoveFirstElement();
                return;
            }
            Node p = PHead;
            for (; p.PNext.Data != x; p = p.PNext) { }
            p.PNext = p.PNext.PNext;
        }
    }
}

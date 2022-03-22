namespace LinkedListV2
{
    public class LinkedListV2<T>
    {
        public Node<T> PHead { get; set; }
        public Node<T> PTail { get; set; }

        public void AddNode(Node<T> node)
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
    }
}

using LinkedListV2;

LinkedListV2<float> linkedListV2 = new LinkedListV2<float>();
linkedListV2.AddNode(new Node<float>(3));
linkedListV2.AddNode(new Node<float>(4));
linkedListV2.AddNode(new Node<float>(5));


for (Node<float> p = linkedListV2.PHead; p != null; p = p.PNext)
{
    Console.WriteLine(p.Data);
}


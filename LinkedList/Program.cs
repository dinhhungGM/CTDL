
using LinkedList;

Console.WriteLine("Nhap vao so luong node: ");
SingleLinkedList list = new SingleLinkedList();
list.InputLinkedList(int.Parse(Console.ReadLine()));

Console.WriteLine("Nhap vao data muon xoa: ");
list.RemoveAnyElement(int.Parse(Console.ReadLine()));
list.DisplayLinkedList();
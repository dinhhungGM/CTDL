using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListV2
{
    /// <summary>
    /// Khai bao rang class Node thuoc kieu generic
    /// T o day kieu du lieu
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> PNext { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }
}

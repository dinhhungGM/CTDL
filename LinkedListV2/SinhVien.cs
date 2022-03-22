using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListV2
{
    public class SinhVien
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }


        public SinhVien(int id, string name, int age)
        {
            ID = id;
            Name = name;
            age = age;
        }
    }
}

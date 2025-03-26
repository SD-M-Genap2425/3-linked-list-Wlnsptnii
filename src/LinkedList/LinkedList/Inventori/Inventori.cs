using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Inventori
{
    public class Item
    {
         public string Nama { get; set; }
         public int Kuantitas { get; set; }

         public Item(string nama, int kuantitas)
         {
             Nama = nama;
             Kuantitas = kuantitas;
         }
    }

    public class ManajemenInventori
    {
        private LinkedList<Item> inventori;

        public ManajemenInventori()
        {
            inventori = new LinkedList<Item>();
        }

        public void TambahItem(Item item)
        {
            inventori.AddLast(item);
        }

        public bool HapusItem(string nama)
        {
            var node = inventori.First;
            while (node != null)
            {
                if (node.Value.Nama == nama)
                {
                    inventori.Remove(node);
                    return true;
                }
                node = node.Next;
            }
            return false;
        }

        public string TampilkanInventori()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in inventori)
            {
                sb.AppendLine($"{item.Nama}; {item.Kuantitas}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Perpustakaan
{
    public class Buku
    {
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public int Tahun { get; set; }

        public Buku(string judul, string penulis, int tahun)
        {
            Judul = judul;
            Penulis = penulis;
            Tahun = tahun;
        }
    }

    public class BukuNode
    {
        public Buku Data { get; set; }  
        public BukuNode? Next { get; set; }

        public BukuNode(Buku buku)
        {
            Data = buku;
            Next = null;
        }
    }


    public class KoleksiPerpustakaan
    {
        private BukuNode? head; 

        public KoleksiPerpustakaan()
        {
            head = null;
        }

        public void TambahBuku(Buku buku)
        {
            BukuNode newNode = new BukuNode(buku);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                BukuNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public bool HapusBuku(string judul)
        {
            bool deleted = false;

            while (head != null && head.Data.Judul.Equals(judul))
            {
                head = head.Next;
                deleted = true;
            }

            BukuNode? current = head;
            while (current?.Next != null)
            {
                if (current.Next.Data.Judul.Equals(judul))
                {
                    current.Next = current.Next.Next;
                    deleted = true;
                }
                else
                {
                    current = current.Next;
                }
            }

            return deleted;
        }



        public Buku[] CariBuku(string judul)
        {
            List<Buku> foundBooks = new List<Buku>();
            BukuNode? current = head;

            while (current != null)
            {
                if (current.Data.Judul.Equals(judul))
                {
                    foundBooks.Add(current.Data);
                }
                current = current.Next;
            }

            return foundBooks.ToArray();
        }

        public string TampilkanKoleksi()
        {
            if (head == null) return string.Empty;

            StringBuilder sb = new StringBuilder();
            BukuNode? current = head;

            while (current != null)
            {
                sb.AppendLine($"\"{current.Data.Judul}\"; {current.Data.Penulis}; {current.Data.Tahun}");
                current = current.Next;
            }

            return sb.ToString().Trim();
        }


    }
}

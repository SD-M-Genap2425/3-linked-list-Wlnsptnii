using System;
using LinkedList.Inventori;
using LinkedList.ManajemenKaryawan;
using LinkedList.Perpustakaan;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soal Perpustakaan
            var koleksi = new KoleksiPerpustakaan();
            var buku1 = new Buku("The Hobbit", "J.R.R. Tolkien", 1937);
            var buku2 = new Buku("1984", "George Orwell", 1949);
            var buku3 = new Buku("The Catcher in the Rye", "J.D. Salinger", 1951);

            koleksi.TambahBuku(buku1);
            koleksi.TambahBuku(buku2);
            koleksi.TambahBuku(buku3);

            Console.WriteLine("Koleksi Buku:");
            koleksi.TampilkanKoleksi();

            Console.WriteLine("\nMenghapus buku '1984':");
            koleksi.HapusBuku("1984");
            koleksi.TampilkanKoleksi();

            Console.WriteLine("\nMencari buku dengan kata kunci 'The':");
            var hasilPencarian = koleksi.CariBuku("The");
            foreach (var buku in hasilPencarian)
            {
                Console.WriteLine($"\"{buku.Judul}\"; {buku.Penulis}; {buku.Tahun}");
            }

            // Soal ManajemenKaryawan
            var daftarKaryawan = new DaftarKaryawan();
            var karyawan1 = new Karyawan("001", "John Doe", "Manager");
            var karyawan2 = new Karyawan("002", "Jane Doe", "HR");
            var karyawan3 = new Karyawan("003", "Bob Smith", "IT");

            daftarKaryawan.TambahKaryawan(karyawan1);
            daftarKaryawan.TambahKaryawan(karyawan2);
            daftarKaryawan.TambahKaryawan(karyawan3);

            Console.WriteLine("\nDaftar Karyawan:");
            daftarKaryawan.TampilkanDaftar();

            Console.WriteLine("\nMenghapus karyawan '002':");
            daftarKaryawan.HapusKaryawan("002");
            daftarKaryawan.TampilkanDaftar();

            Console.WriteLine("\nMencari karyawan dengan kata kunci 'IT':");
            var hasilCariKaryawan = daftarKaryawan.CariKaryawan("IT");
            foreach (var karyawan in hasilCariKaryawan)
            {
                Console.WriteLine($"{karyawan.NomorKaryawan}; {karyawan.Nama}; {karyawan.Posisi}");
            }

            // Soal Inventori
            var manajemenInventori = new ManajemenInventori();
            var item1 = new Item("Apple", 50);
            var item2 = new Item("Orange", 30);
            var item3 = new Item("Banana", 20);

            manajemenInventori.TambahItem(item1);
            manajemenInventori.TambahItem(item2);
            manajemenInventori.TambahItem(item3);

            Console.WriteLine("\nInventori:");
            manajemenInventori.TampilkanInventori();

            Console.WriteLine("\nMenghapus item 'Orange':");
            manajemenInventori.HapusItem("Orange");
            manajemenInventori.TampilkanInventori();
        }
    }
}

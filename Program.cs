using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mahasiswa> listMahasiswa = new List<Mahasiswa>();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("Menu :\n1. Tambah\n2. Hapus\n3. Tampilkan\n4. Keluar");
                Console.Write("Pilihan: ");
                int ch = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case 1:
                        Tambah();
                        break;
                    case 2:
                        Hapus();
                        break;
                    case 3:
                        Tampilkan();
                        break;
                    case 4:
                        Keluar();
                        break;
                }
            }

            void Tambah()
            {
                Mahasiswa mhs = new Mahasiswa();

                Console.Write("NIM: ");
                mhs.Nim = Console.ReadLine();
                Console.Write("Nama: ");
                mhs.Nama = Console.ReadLine();

                listMahasiswa.Add(mhs);
            }

            void Hapus()
            {
                Console.Write("Masukkan NIM: ");
                string search = Console.ReadLine();

                int index = 0;
                foreach(Mahasiswa mhs in listMahasiswa)
                {
                    if(mhs.Nim == search)
                    {
                        break;
                    }

                    index++;
                }
                listMahasiswa.RemoveAt(index);
            }
    
            void Tampilkan()
            {
                Console.WriteLine("No\t\tNIM\t\tNama");

                int index = 0;
                foreach(Mahasiswa mhs in listMahasiswa)
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", index+1, mhs.Nim, mhs.Nama);
                    index++;
                }
            }

            void Keluar()
            {
                exit = true;
            }
        }
    }
}

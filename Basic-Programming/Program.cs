using System;
using System.Net.Security;

namespace Basic_Programming
{
    class Program
    {
        public static void Main(String[] args)
        {
            beranda();
        }

        static void beranda()
        {
            Console.WriteLine(" ===== SELAMAT DATANG DI JUALTIKET. ===== ");
            Console.WriteLine();

            //coba untuk dibuat method agar memanggil saja
            Console.Write("Masukan Nama Depan: ");
            var nama = Console.ReadLine(); //variabel nama
            Console.WriteLine("------------------------------");
            Console.Write("Masukan Nama Belakang: ");
            var nama_belakang = Console.ReadLine(); //variabel naMA BELAKANG
            Console.WriteLine("------------------------------");
            Console.Write("Masukan Jenis Kelamin: ");
            var jk = Console.ReadLine(); //variabel jenis kelamin
            Console.WriteLine("------------------------------");
            Console.Write("Masukan Alamat: ");
            var alamat = Console.ReadLine(); //variabel alamat
            Console.WriteLine("------------------------------");
            Console.Write("Silahkan Masukan Umur Anda: ");

            //decision
            int umur = int.Parse(Console.ReadLine());
            if (umur >= 17)
            {
                Console.WriteLine("Kamu berusia " + umur + " Tahun");
                Console.WriteLine("Silahkan Masuk");
            }
            else
            {

                Console.WriteLine("Tidak Boleh, Harus dengan bimbingan orang tua");
                return;
            };
            Console.Clear();
            Console.WriteLine(" == SELAMAT DATANG DI JUALTIKET. == ");
            Console.WriteLine();
            Console.WriteLine("Selamat Datang " + nama + "");
            Console.WriteLine("Silahkan Pilih Tiket Yang Anda Ingin Beli");
            Console.WriteLine();

            //array
            string[] listTiket = { "Tiket Tribun 1", "Tiket Tribun 2", "Tiket Tribun 3", "Tiket VIP" };
            for (int i = 0; i < listTiket.Length; i++) //looping untuk Array list tiket
            {
                Console.WriteLine($"{i + 1}. {listTiket[i]}"); //looping + 1
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine();
            Console.Write("Pilih Jenis Tiket : ");
            int pilihan = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("=================================");
            /*var listproduk = new List<string>();
            listproduk.Add("Nama: Tiket Tribun 1");
            listproduk.Add("Nama: Tiket Tribun 2");
            listproduk.Add("Nama: Tiket Tribun 3");
            listproduk.Add("Nama: Tiket VIP");*/

            Console.WriteLine("Keterangan: ");
            int harga = 0; //switch case harga dan nama tiket
            switch (pilihan)
            {
                case 1:
                    harga = 50000;
                    Console.WriteLine("Nama: Tiket Tribun 1");
                    break;
                case 2: 
                    harga = 100000;
                    Console.WriteLine("Nama: Tiket Tribun 2");
                    break;
                case 3:
                    harga = 200000;
                    Console.WriteLine("Nama: Tiket Tribun 3");
                    break;
                case 4:
                    harga = 500000;
                    Console.WriteLine("Nama: Tiket VIP");
                    break;
                default:
                    Console.WriteLine("Tidak Ada Tiket Lain.");
                    break;
            }

            Console.WriteLine($"Dengan Harga: RP. " + harga + ""); // $ bisa untuk memanggil
            Console.WriteLine("=================================");
            Console.Write("Masukan Jumlah Yang Dibeli: ");
            int jumlah = int.Parse(Console.ReadLine());

            int total_hitung = hitung(harga, jumlah);
            Console.Write("Total Harga: " + hitung(harga, jumlah));
            Console.WriteLine();
            Console.Write("Silahkan Bayar: ");
            var pembayaran = int.Parse(Console.ReadLine());

            var uang_bayar = bayar(pembayaran, hitung(harga, jumlah));
            Console.WriteLine();
            Console.WriteLine("Kembalian: " + bayar(pembayaran, hitung(harga, jumlah)));
            Console.WriteLine();

            if (pembayaran < total_hitung)
            {
                Console.WriteLine("Mohon bayar dengan uang pas");
                pembayaran = int.Parse(Console.ReadLine());
                Console.WriteLine("Kembalian: " + bayar(pembayaran, hitung(harga, jumlah)));
            }
            else
            {
                Console.WriteLine("Uang sudah pas");
                Console.WriteLine();            
            }

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Apakah ingin mencetak nota? Y/N");
            var chance = Console.ReadLine().ToLower();

            //decision
            //Untuk yes / no
            if (chance == "y")
            {
                Console.Clear();
                Tampil(nama, harga, jumlah, nama_belakang, jk, alamat,pembayaran, uang_bayar);
                Console.WriteLine();
                Console.WriteLine(" Terimakasih telah membeli");
                Console.WriteLine(" ==========SALAM HANGAT======== ");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(" Terimakasih telah berbelanja");
                Console.WriteLine(" ==========SALAM HANGAT======== ");
            }
        }

        //function hitung (Method Non Void) tidak boleh berisi console
        static int hitung(int harga, int jumlah)
        {
            return harga * jumlah; //operator perkalian
        }

        //method pembayaran
        static int bayar(int pembayaran, int hitung)
        {
            return pembayaran - hitung; //OPERATOR kurang
        }

        //Method Void Tampil Nota(Method Void)
        static void Tampil(string nama, int harga, int jumlah, string nama_belakang, string jk, string alamat, int pembayaran, int uang_bayar)
        {
            Console.WriteLine(" ==========NOTA PEMBELIAN======== ");
            Console.WriteLine();
            Console.WriteLine(" Nama                 = " + nama + " " + nama_belakang+ "");
            Console.WriteLine(" Jenis Kelamin        = " + jk);
            Console.WriteLine(" Alamat Pembeli       = " + alamat);
            Console.WriteLine(" Harga Tiket (Pcs)    = RP. " + harga + "");
            Console.WriteLine(" Jumlah Tiket dipesan = " + jumlah + " PCs");
            Console.Write(" Total harga Tiket    = RP. " + (hitung(harga, jumlah)));
            Console.WriteLine();
            Console.WriteLine(" Bayar dengan uang    = RP. " + pembayaran);
            Console.WriteLine(" Uang Kembalian       = RP. " + uang_bayar);
            Console.WriteLine();
        }
    }
}

//catatan!!!
// 1. Kalau bisa di public static void main cuma tinggal manggil method aja (DONE)
// 2. bikin fungsi bayar (DONE)
// 3. Buat Kondisi apabila bayar: bisa bayar, masukan uang yg cukup jika tidak pas(DONE)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            // int a = 10; //deklarasi variabel a, dengan nilai awal 10;
            // int b = 6; //declarasi variabel b, dengan nilai awal 6;

            Console.WriteLine("Selamat Datang di Aplikasi Kalkulator");
            Console.WriteLine("Nama     : Muhamad Rosyid Ridlo");
            Console.WriteLine("Kelas    : 20-IF-02");
            Console.WriteLine("NIM      : 20.11.3801");

            do {
                Console.WriteLine("=============================================");
                Console.WriteLine("||        Menu Aplikasi Kalkulator         ||");
                Console.WriteLine("||                                         ||");
                Console.WriteLine("|| 1. Penjumlahan                          ||");
                Console.WriteLine("|| 2. Pengurangan                          ||");
                Console.WriteLine("|| 3. Perkalian                            ||");
                Console.WriteLine("|| 4. Pembagian                            ||");
                Console.WriteLine("||                                         ||");
                Console.WriteLine("=============================================");
                Console.Write("Masukkan Pilihan Operasi : ");
                int pil = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); //proses casting

                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); //proses casting

                Console.WriteLine(); //tambahkan baris kosong

                if (pil == 1) {
                    Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan (a, b));
                } else if (pil == 2) {
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                } else if (pil == 3) {
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                } else if (pil == 4) {
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                } else {
                    Console.WriteLine("Operasi tidak tersedia, masukkan angka 1-4");
                }
                
                Console.WriteLine("\nTekan y/Y untuk mengulangi operasi, dan tekan sembarang untuk keluar");

            } while (Console.ReadKey().Key == ConsoleKey.Y);

            Console.WriteLine();
            Console.WriteLine("Terimakasih telah mencoba program ini");
            Console.WriteLine("Program ini dibuat oleh Muhamad Rosyid Ridlo");
        }
        
        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
        
    }
}

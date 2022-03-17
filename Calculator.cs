using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
	class Program
	{
		static int Penambahan (int a, int b)
        {
            return a + b;
        }

        static int Pengurangan (int a, int b)
        {
            return a - b;
        }

        static int Perkalian (int a, int b)
        {
            return a * b;
        }

        static int Pembagian (int a, int b)
        {
            return a / b;
        }
		
		static void Main(string[] args)
		{
            Console.Title = "Aplikasi Calculator";

            char pilihan;
            Console.WriteLine("Pilih Menu Calculator:");
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();
            Console.WriteLine("Inputkan nomor menu [1-4]: ");
            pilihan = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            if (pilihan == '1')
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }

            else if (pilihan == '2')
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
            }

            else if (pilihan == '3')
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + Perkalian(a, b));
            }

            else if (pilihan == '4')
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + Pembagian(a, b));
            }

            else
            {
                Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia!");
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
    }
}
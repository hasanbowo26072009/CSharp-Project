using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hewan_kesukaan
{
    class Program
    {
       static void Main(string[] args)
        {         
            Console.WriteLine("====== pilih hewan kesukaan ======");
            Console.WriteLine();
            Console.WriteLine("1. Kucing");
            Console.WriteLine("2. Anjing");
            Console.WriteLine("3. Burung");
            Console.WriteLine("4. Ikan");
            Console.WriteLine("5. Kelinci");
            Console.Write("Masukkan pilihan Anda (1-5): ");
            Console.WriteLine();
            int pilihan = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (pilihan == 1)
            {
                Console.WriteLine("Hewan kesukaan Anda adalah Kucing");
            }
            else if (pilihan == 2)
            {
                Console.WriteLine("Hewan kesukaan Anda adalah Anjing");
            }
            else if (pilihan == 3)
            {
                Console.WriteLine("Hewan kesukaan Anda adalah Burung");
            }
            else if (pilihan == 4)
            {
                Console.WriteLine("Hewan kesukaan Anda adalah Ikan");
            }
            else if (pilihan == 5)
            {
                Console.WriteLine("Hewan kesukaan Anda adalah Kelinci");
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid");
            }
        }
    } 
}        
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsponsiPemrograman4398
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan k1 = new Karyawan("190356784", "Anya", Int32.Parse("2000000"));
            Karyawan k2 = new Karyawan("190364873", "Dana", Int32.Parse("-100000"));

            Console.WriteLine("No Nik / Nama\t\tGaji Bulanan");
            Console.WriteLine("-------------------------------------");
            CetakHasil1(k1);
            CetakHasil2(k2);

            Console.WriteLine();

            Console.WriteLine("Asyik dapa kenaikan gaji 10%!!");

            Console.WriteLine();

            Console.WriteLine("No Nik / Nama\t\tGaji Bulanan");
            Console.WriteLine("-------------------------------------");
            CetakHasil3(k1);
            CetakHasil4(k2);

            Console.ReadKey();
        }
        static void CetakHasil1(Karyawan k)
        {
            Console.WriteLine("1. {0} {1}\t{2}", k.Nik, k.Nama, k.GajiBulanan);
        }
        static void CetakHasil2(Karyawan k)
        {
            Console.WriteLine("2. {0} {1}\t{2}", k.Nik, k.Nama, k.GajiBulanan);
        }
        static void CetakHasil3(Karyawan k)
        {
            Console.WriteLine("1. {0} {1}\t{2}", k.Nik, k.Nama, k.GajiBulanan + k.GajiBulanan * 10/100);
        }
        static void CetakHasil4(Karyawan k)
        {
            Console.WriteLine("2. {0} {1}\t{2}", k.Nik, k.Nama, k.GajiBulanan + k.GajiBulanan * 10 / 100);
        }
    }
}

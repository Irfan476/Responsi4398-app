using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsponsiPemrograman4398
{
    public class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(string nik, string nama, int gajibul)
        {
            Nik = nik;
            Nama = nama;
            GajiBulanan = gajibul;
            if(GajiBulanan < 0)
            {
                GajiBulanan = 0;
            }
        }
    }
}

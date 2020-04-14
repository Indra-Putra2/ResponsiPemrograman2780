using System;

namespace ResponsiPemrograman2780
{
    class Karyawan
    {
        public int NIK { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public int NaikGaji { get; set; }

        public Karyawan(int nik, string nama, int gajiBulanan)
        {
            NIK = nik;
            Nama = nama;

            if (gajiBulanan > 0)
            {
                GajiBulanan = gajiBulanan;
                NaikGaji = Convert.ToInt32(GajiBulanan * 1.1);
            }
            else
            {
                GajiBulanan = 0;
            }

        }

    }
}
using System;

namespace ResponsiPemrograman2780
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama     : Indra Putra gemilang");
            Console.WriteLine("NIM      : 19.11.2780");
            Console.WriteLine("Kelas    : 19 Informatika 03");

            Console.WriteLine("\n");


            Karyawan karyawan1 = new Karyawan(19113506, "Indra", 8000000);
            Karyawan karyawan2 = new Karyawan(19113543, "Tejo", 5000000);
            Karyawan karyawan3 = new Karyawan(19113543, "Ari\t", -900000);


            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(" 1.  {0} {1} \t\t  {2}\t ", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine(" 2.  {0} {1} \t\t  {2}\t ", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine(" 3.  {0} {1} \t  {2} ", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);

            Console.WriteLine("\n\nAsikkkkk kenaikan gaji 10%\n");

            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");            
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(" 1.  {0} {1} \t\t  {2} ", karyawan1.NIK, karyawan1.Nama, karyawan1.NaikGaji);
            Console.WriteLine(" 2.  {0} {1} \t\t  {2} ", karyawan2.NIK, karyawan2.Nama, karyawan2.NaikGaji);
            Console.WriteLine(" 3.  {0} {1} \t  {2} ", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);
            Console.ReadKey();
        }
    }

}
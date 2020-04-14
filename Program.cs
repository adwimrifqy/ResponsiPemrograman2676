using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2676
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kw1 = new Karyawan("18112357", "Paijo", 3000000);
            Tampil(kw1);
            Karyawan k2 = new Karyawan("18112234", "Jono", 2000000);
            Tampil(kw2);

            Console.WriteLine("\nAlhamdulillah gaji naik 10%\n");
            Tampil2(kw1);
            Tampil2(kw2);

            Console.ReadKey();
        }
        static void Tampil(Karyawan kw)
        {
            if (kw.Nama == "Paijo")
            {
                Console.WriteLine("No.   NIK/Nama             Gaji Bulanan");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1.    {0}/{1}          {2}", kw.NIK, kw.Nama, kw.gajiBulanan);
            }
            else
            {
                Console.WriteLine("2.    {0}/{1}         {2}", kw.NIK, kw.Nama, kw.gajiBulanan);
            }
        }
        static void Tampil2(Karyawan i)
        {
            int naik, total;
            naik = (10 * i.gajiBulanan) / 100;
            total = i.gajiBulanan + naik;
            if (i.Nama == "Paijo")
            {
                Console.WriteLine("No.   NIK/Nama             Gaji Bulanan");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1.    {0}/{1}          {2}", i.NIK, i.Nama, total);
            }
            else
            {
                Console.WriteLine("2.    {0}/{1}         {2}", i.NIK, i.Nama, total);
            }
        }
    }
}

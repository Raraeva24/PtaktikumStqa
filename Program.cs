using System;

namespace Menghitung_Bangun_Datar
{
    /// <summary>
    /// Main Menu
    /// </summary>
    /// <remarks>Menghitung Salah Satu Bangun Datar Berupa Persegi Panjang</remarks>
    class persegipanjang
    {
        /// <summary>
        /// input, proses, dan output data
        /// </summary>
        /// <param name="p">ini panjangnya</param>
        /// <param name="l">ini luasnya</param>
        private double p, l, luas;
        public void inputdata()
        {
            Console.WriteLine("masukkan panjangnya");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("masukkan lebarnya");
            l = Convert.ToDouble(Console.ReadLine());
        }
        public void prosesdata()
        {
            luas = p * l;
        }
        public void outputdata()
        {
            Console.WriteLine("panjang {0}, lebar {1}, luas {2}", p, l, luas);

        }
        static void Main (string[] args)
        {
            persegipanjang pp = new persegipanjang();

            pp.inputdata();
            pp.prosesdata();
            pp.outputdata();
        }
    }
}
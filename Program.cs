using System;
namespace Menghitung_Bangun_Datar
{ 
    /// <summary>
    /// ini merupakan sebuah kontainer yang bersiri kelas bangun datar
    /// </summary>
    class persegipanjang
    {
        /// <summary>
        /// kelas persegi pangjang merupakan sebuah kelas yang ada didalam namespace 
        /// </summary>
        /// <remarks> kelas ini berisi bberapa metode seperti input data, proses data, dan outpur data </remarks>
        /// <param name = "p" > ini merupakan sebuah parameter untuk menentukan panjang persegi panjang </ param >
        /// 
        /// <param name = "l" > ini merupakan sebuah parameter untuk menentukan lebar persegi panjang </ param
        private double p, l, luas;
        public void inputdata()
        {
            /// <summary> ini merupakan salah  bagian dari input data yang berisi deklarasi mengenai pengisian pangjang dan lebar persegi panjang</summary>
            /// <remarks> 
            /// <para> console.writeline</para>
            /// <para> berfungsi untuk menampilkan kalimat "masukkan panjangnya" dan juga kalimat "masukkan lebarnya" </para>
            /// </remarks>
            Console.WriteLine("masukkan panjangnya");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("masukkan lebarnya");
            l = Convert.ToDouble(Console.ReadLine());
        }
        public void prosesdata()
        {
            /// <summary> bagian ini brfugnsi untuk memproses data yang telah diinputkan </summary>
            /// <param name = " p"> adalah panjang </param>
            /// <param name = " l"> adalah lebarnya </param>
            /// <param name = " luas"> adalah luas dari hasil perhitungnya panjang persegi panjang </param>
            luas = p * l;
        }
        public void outputdata()
        {
            ///<summary> bagian ini untuk meeberikan perintah memperlihatkan output data</summary>
            Console.WriteLine("panjang {0}, lebar {1}, luas {2}", p, l, luas);

        }
        static void Main (string[] args)
        {
            /// <summary>bagian ini untuk memamnggil kelas agar bisa tampil di layar anda </summary>
            persegipanjang pp = new persegipanjang();

            pp.inputdata();
            pp.prosesdata();
            pp.outputdata();
        }
    }
}

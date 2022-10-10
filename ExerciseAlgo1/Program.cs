using System;

namespace ExeciseAlgo1
{
    class Program
    {
        //deklarassi array int dengan ukuran 20
        private int[] amin = new int[36];

        //deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        //Fungsi / Method untuk menerima masukan
        public void read()
        {
            //menerima angka untuk menetukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya element Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 36)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 36 elemen. \n");
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Masukkan elemen Array");
            Console.WriteLine("---------------------");

            //pengguna memasukkan element pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                amin[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Element array yang telah tersusun ");
            Console.WriteLine("----------------------------------");
            for (int af = 0; af < n; af++)
            {
                Console.WriteLine(amin[af]);
            }
            Console.WriteLine("");
        }
        public void BubblesortArray()
        {
            for (int i = 1; i < n; i++)//For n - 1 passes
            {
                //Pada pass i, bandingkan n- i element pertama dengan element selanjutnya

                for (int af = 0; af < n - 1; af++)
                {
                    if (amin[af] > amin[af + 1])//jika element tidak dalam urutan yang benar
                    {
                        //tukar element
                        int temp;
                        temp = amin[af];
                        amin[af] = amin[af + 1];
                        amin[af + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Creating the object of the bubble short
            Program myList = new Program();

            //pemanggilan fungsi untuk menerima element array
            myList.read();
            //pemanggilan fungsi untuk mengurutkan array
            myList.BubblesortArray();
            //pemanggilan fungsi untuk menampilkan array tersusun
            myList.display();
            //exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev17
{
    class Ödev17
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();

            Console.WriteLine(ogr.Ogrencino);
            Console.WriteLine(ogr.Ad);
            Console.WriteLine(ogr.Soyad);
            Console.WriteLine(ogr.Bolum);
            Console.WriteLine(ogr.Sinif);
            Console.ReadLine();
        }
    }

    class Ogrenci
    {
        public ulong Ogrencino;
        public string Ad;
        public string Soyad;
        public string Bolum;
        public byte Sinif;
    }
}

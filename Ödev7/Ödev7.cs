using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev7
{
    class Ödev7
    {
        static int BuyukBul(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static int BuyukBul3(int a, int b,int c)
        {
            return BuyukBul(a, BuyukBul(b, c));
        }

        static void Main(string[] args)
        {
            int s1, s2, s3;
            Console.WriteLine("1. Sayıyı Giriniz: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. Sayıyı Giriniz: ");
            s3 = Convert.ToInt32(Console.ReadLine());

            int enBuyuk = BuyukBul3(s1, s2, s3);

            Console.WriteLine("En büyük: " + enBuyuk);
            Console.ReadLine();
        }
    }
}

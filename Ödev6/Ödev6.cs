using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev6
{
    class Ödev6
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

        static void Main(string[] args)
        {
            int s1, s2;
            Console.WriteLine("1. Sayıyı Giriniz: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz: ");
            s2 = Convert.ToInt32(Console.ReadLine());

            int enBuyuk = BuyukBul(s1, s2);

            Console.WriteLine("En Büyük :" + enBuyuk);
            Console.ReadLine();
        }
    }
}

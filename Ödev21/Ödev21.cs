using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21
{
    class Ödev21
    {
        public static int En = 30; 
        public static int Boy = 23;
        public static int Alan()
        { 
            int Alan = En * Boy; return Alan; 
        }


        static void Main(string[] args)
        {
            yaz d1 = new yaz(); d1.Yaz();
        }
    }
    class yaz
    {
        public void Yaz()
        {
            Console.WriteLine("En:{0,5}", Ödev21.En);
            Console.WriteLine("Boy:{0,5}", Ödev21.Boy);
            Console.WriteLine("Alan:{0,5}", Ödev21.Alan());
            Console.ReadLine();
        }
    }
}

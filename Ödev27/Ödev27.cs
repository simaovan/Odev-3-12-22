using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev27
{
    class Deneme
    {
        public int a;
        public int b;

        public Deneme(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static int Topla(int x, int y)
        {
            return x + y;
        }
    }

    class Ödev27
    {
        static void Main(string[] args)
        {
            Deneme d = new Deneme(1, 2);
            Console.WriteLine(d.a);
            Console.WriteLine(Deneme.Topla(2, 3));
            Console.ReadLine();
        }
    }
}

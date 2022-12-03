using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev24
{
    class Toplama
    {
        public int x;
        public int y;

        public Toplama(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Toplama() : this(-1, -1) { }
        public Toplama(int x): this(x, 1) { }
        public int Islem()
        {
            return x + y;
        }
        public void Yaz()
        {
            Console.WriteLine("X = {0}", x);
            Console.WriteLine("Y = {0}", y);
        }
    }

    class Ödev24
    {
        static void Main(string[] args)
        {
            Toplama t = new Toplama(5, 6);
            t.Yaz();
            Toplama y = new Toplama();
            y.Yaz();
            Toplama u = new Toplama(7);
            u.Yaz();
            Console.ReadLine();
        }
    }
}

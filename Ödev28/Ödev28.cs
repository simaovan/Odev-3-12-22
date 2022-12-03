using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isimalan1
{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 1");
        }
    }
}

namespace isimalan2
{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 2");
        }
    }
}

namespace Ödev28
{
    class Ödev28
    {
        static void Main(string[] args)
        {
            isimalan1.Deneme d1 = new isimalan1.Deneme();
            isimalan2.Deneme d2 = new isimalan2.Deneme();
            Console.ReadLine();
        }
    }
}

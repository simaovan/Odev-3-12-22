using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev29
{
    class Ödev29
    {
        static void Main(string[] args)
        {
            if (BitConverter.IsLittleEndian)
                Console.WriteLine("Little Endian");
            else
                Console.WriteLine("Big Endian");

            int a = 46513;

            byte[] b = BitConverter.GetBytes(a);

            foreach (byte x in b)
                Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}

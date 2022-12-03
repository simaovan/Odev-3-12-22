using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev25
{
    class Ödev25
    {
        public int Zar()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
        public static void metotlar(int a,int b,int c)
        {
            Console.WriteLine("a= " + a + " b= " + b + " c= " + c);
        }
        static void Main(string[] args)
        {
            Ödev25 a = new Ödev25();
            metotlar(a.Zar(), a.Zar(), a.Zar());
            Console.ReadLine();
        }
    }
}

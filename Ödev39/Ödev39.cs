using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev39
{
    class Ödev39
    {
        class A
        {
            public void Metot1()
            { Metot2(); }
            virtual public void Metot2()
            { 
                Console.WriteLine("A sınıfı"); 
            }
        }
        class B : A
        {
            override public void Metot2()
            { 
                Console.WriteLine("B sınıfı"); 
            }
        }


        static void Main(string[] args)
        {
            B b = new B();
            b.Metot1();
            Console.Read();
        }
    }
}

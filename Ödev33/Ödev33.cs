using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev33
{
    public class Hayvan
    {
        protected String a = "Hayvan.a";
        String b = "Hayvan.b";
        private String c = "Hayvan.c";
        public String d = "Hayvan.d";
    }
    public class Kedi : Hayvan
    {
        public Kedi()
        {
            Console.WriteLine("Kedi olusturuluyor");
            Console.WriteLine(a);
            Console.WriteLine(d);
        }
    }

    class Ödev33
    {
        static void Main(string[] args)
        {
            Kedi k = new Kedi();
            Console.ReadLine();
        }
    }
}

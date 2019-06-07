using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
            o.i = 10;
            o.j = 20;
            o = o + 5;
            //o = o - 5;
            //public static Class1 operator-(Class1 o, int i)


            //o = o + o;
            //public static Class1 operator-(Class1 o, Class1 i)

            //o++;
            //public static Class1 operator++(Class1 o)

            Console.WriteLine(o.i);
            Console.WriteLine(o.j);
            Console.ReadLine();
        }
    }

    public class Class1
    {
        public int i { get; set; }
        public int j{ get; set; }

        public static Class1 operator+(Class1 o, int i)
        {
            Class1 retobj = new Class1();
            retobj.i = o.i + i;
            retobj.j = o.j - i;

            return retobj;

        }
    }
}

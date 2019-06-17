

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndValue
{
    class Program
    {
        static void Main1()
        {
            Class1 o1 = new Class1();
            Class1 o2 = new Class1();

            o1.i = 100;
            o2.i = 200;
            o1 = o2;
            o2.i = 300;
            Console.WriteLine(o1.i);
            Console.WriteLine(o2.i);
            Console.ReadLine();
        }

        //200,300
        //300,300
        static void Main2()
        {
            int o1, o2;
            o1 = 100;
            o2 = 200;
            o1 = o2;
            o2 = 300;
            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.ReadLine();
        }

        //300,300
        static void Main8()
        {
            string o1, o2; //stirng are immutables
            o1 = "shubham";
            o2 = "tanaji";
            o1 = o2;
            o2 = "kumbhar";
            Console.WriteLine("O1  "+o1); //200
            Console.WriteLine("o2   "+o2); //300
            Console.ReadLine();
        }

        static void Main()
        {
            int i = 100;
            object o;
            o = i; //boxing
            int j = (int)o; //unboxing
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
    public class Class1
    {
        public int i;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefForRefTypes
{
    class Program
    {
        static void Main()
        {
            Class1 o = new Class1();
            o.i = 100;
            o.j = 101;
            Console.WriteLine("Befor no change    :   i:  " + o.i + " j:  " + o.j);


            DoSomething1(o);
            Console.WriteLine("DoSomething1    :   i:  "+o.i);
            Console.WriteLine();

            DoSomething2(o);

            Console.WriteLine("DoSomething2    :   i:  " + o.i + " j:  " + o.j);
            Console.WriteLine();

            DoSomething3(ref o);
            Console.WriteLine("DoSomething3    :   i:  " + o.i + " j:  " + o.j);
           
            Console.ReadLine();
        }
        //reference type passed. changes made here reflect in calling code
        static void DoSomething1(Class1 obj)
        {
            obj.i = 200;

        }
        //reference type passed. if memory is reallocated then original variable does not change
        static void DoSomething2(Class1 obj)
        {
            obj = new Class1();
            obj.i = 700;
        }
        //reference type passed. passing reference type as ref allows changes to original variable when memory
        static void DoSomething3(ref Class1 obj)
        {
            obj = new Class1();
            obj.i = 900;
        }
    }

    public class Class1
    {
        public int i;
        public int j;

    }
}

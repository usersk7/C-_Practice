using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling1
{
    class Program
    {
        static void Main1()
        {
            Class1 obj = new Class1();
            InvalidP1EventHandler objDel = new InvalidP1EventHandler(obj_InvalidP1);
            obj.InvalidP1 += objDel;
            obj.P1 = -100;
            Console.ReadLine();
        }
        static void Main2()
        {
            Class1 obj = new Class1();
            obj.InvalidP1 += obj_InvalidP1;
            obj.P1 = -1;
            Console.ReadLine();
        }
        static void Main3()
        {
            Class1 obj = new Class1();
            obj.InvalidP1 += obj_InvalidP1;
            obj.InvalidP1 += Handler2;
            obj.P1 = -1;

            Console.WriteLine();
            obj.InvalidP1 -= Handler2;
            obj.P1 = -1;

            Console.ReadLine();
        }

        private static void obj_InvalidP1()
        {
            Console.WriteLine("event handled here");
        }
        private static void Handler2()
        {
            Console.WriteLine("event handled here also");
        }
    }

    //step 1 : create a delegate class having the same signature as the event handler
    public delegate void InvalidP1EventHandler();
    class Class1
    {
        //step 2 : create the event of the delegate type
        public event InvalidP1EventHandler InvalidP1;

        private int p1;
        public int P1
        {
            get { return p1; }
            set
            {
                if (value > 0)
                    p1 = value;
                else
                {
                    //step 3: raise the event here
                    if(InvalidP1 != null)
                        InvalidP1();
                }

            }
        }

    }

}


/* TO DO
 1 event, multiple handlers
obj.Event1 --> H1
obj.Event1 --> H2


multiple events, same handler

o1.E1  --> H1
o1.E2  --> H1
o2.E1  --> H1
o2.E3  --> H1
  */


namespace EventHandling2
{
    class Program
    {
        static void Main()
        {
            Class1 obj = new Class1();
            obj.InvalidP1 += Obj_InvalidP1;
            obj.P1 = -1;
            Console.ReadLine();
        }

        private static void Obj_InvalidP1(int InvalidValue)
        {
            Console.WriteLine("EVENT HANDLED HERE");
            Console.WriteLine("INVALID VALUE  =" + InvalidValue);
        }
    }

    //step 1 : create a delegate class having the same signature as the event handler
    public delegate void InvalidP1EventHandler(int InvalidValue);
    class Class1
    {
        //step 2 : create the event of the delegate type
        public event InvalidP1EventHandler InvalidP1;

        private int p1;
        public int P1
        {
            get { return p1; }
            set
            {
                if (value > 0)
                    p1 = value;
                else
                {
                    //step 3: raise the event here
                    if (InvalidP1 != null)
                        InvalidP1(value);
                }

            }
        }

    }

}
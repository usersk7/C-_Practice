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
            //step4 create delegate object
            InvalidP1EventHandler objDel = new InvalidP1EventHandler(method1);

            obj.InvalidP1 += objDel;
            obj.P1 = -100;
            Console.ReadLine();
        }
        static void Main4()
        {
            Class1 obj = new Class1();
            //obj.InvalidP1 += method1;
            obj.P1 = -1;
            Console.ReadLine();
        }
        static void Main()
        {
            Class1 obj = new Class1();
            obj.InvalidP1 += method1;
            obj.InvalidP1 += method2;
            obj.P1 = -1;

            Console.WriteLine();
            obj.InvalidP1 -= method2;
            obj.P1 = -1;

            Console.ReadLine();
        }

        private static void method1()
        {
            Console.WriteLine("event handled here");
        }
        private static void method2()
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
 * 
 * 
 * 

        //step 1 : create a delegate class having the same signature as the event handler
        public delegate void InvalidP1EventHandler();  

        //step 2 : create the event of the delegate type
        public event InvalidP1EventHandler InvalidP1;

        //step 3: raise the event here
                        if(InvalidP1 != null)
                            InvalidP1();

       //step4 create delegate object
            InvalidP1EventHandler objDel = new InvalidP1EventHandler(method1);
            obj.InvalidP1 += objDel;
            obj.P1 = -100;
           


 * 
 * 
 * 
 1 event, multiple handlers(method)
obj.Event1 --> H1
obj.Event1 --> H2


multiple events(dell objject), same handler

o1.E1  --> H1
o1.E2  --> H1
o2.E1  --> H1
o2.E3  --> H1
  */


namespace EventHandling2
{
    class Program
    {
        static void Main1()
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
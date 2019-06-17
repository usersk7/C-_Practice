using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Del1();
    public delegate void Del2(string s);
    public delegate int Del3(int a, int b);
    class Program
    {
        static void Main1()
        {
            Del1 objDel = new Del1(Display);
            objDel();
            Console.ReadLine();
        }
        static void Main2()
        {
            Del1 objDel;
            objDel = new Del1(Display);
            objDel();

            Console.WriteLine();
            objDel = new Del1(Show);
            objDel();

            objDel();

            Console.ReadLine();
        }
        static void Main()
        {
            Del1 objDel;
            objDel = new Del1(Display);
           // objDel();

            objDel += new Del1(Show);
            objDel += new Del1(Display);
            objDel += new Del1(Show);

            Console.WriteLine("calling");
            objDel();

            Console.ReadLine();
        }
        static void Main4()
        {
            Del1 objDel;
            objDel = new Del1(Display);
            objDel();

            objDel += new Del1(Show);
            objDel += new Del1(Display);
            objDel += new Del1(Show);

            Console.WriteLine();
            objDel();

            Console.WriteLine();
            objDel -= new Del1(Display);
            objDel();


            Console.ReadLine();
        }

        static void Main5()
        {
            Del1 objDel;
            objDel = Display;
            objDel();

            objDel += Show;
            objDel += Display;
            objDel += Show;

            Console.WriteLine();
            objDel();

            Console.WriteLine();
            objDel -= Display;
            objDel();

            Console.ReadLine();
        }
        static void Main6()
        {
            Del1 objDel;
            objDel = Display;

            objDel =(Del1) Delegate.Combine(objDel, new Del1(Show), new Del1(Display), new Del1(Show));

            objDel();

            Console.WriteLine();

            //objDel = (Del1)Delegate.Remove(objDel, new Del1(Display));
            objDel = (Del1)Delegate.RemoveAll(objDel, new Del1(Display));
            objDel();
            Console.ReadLine();
        }

        static void Main7()
        {
            Del2 o = Display;
            o("a");

            Del3 o3 = Add;
            int ans = o3(10, 20);
            Console.WriteLine(ans);

            Del1 o4 = class2.Show;
            o4();

            class2 oCls2 = new class2();
            Del1 o5 = oCls2.Show2;
            o5();

            Console.ReadLine();
        }

        static void Display(){ Console.WriteLine("disp"); }
        static void Show() { Console.WriteLine("show"); }

        static void Display(string s) { Console.WriteLine("disp" + s); }
        static int Add(int a, int b)  {    return a + b;     }
       
    }

    class class2
    {
        public static void Show()
        {
            Console.WriteLine("show");
        }
        public void Show2()
        {
            Console.WriteLine("show2");
        }


    }

}

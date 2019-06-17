using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncCodeWithDelegates1 
{

    public delegate void Del1();
    class Program
    {
        static void Main1()
        {
            Console.WriteLine("Before");
            Del1 obj = Display;
            obj.BeginInvoke(null, null);
            Console.WriteLine("After");
            Console.ReadLine();
        }
        static void Display()
        {
            //System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Display");
        }
    }
}

namespace AsyncCodeWithDelegates2
{

    public delegate void Del1(string s);
    class Program
    {
        static void Main2()
        {
            Console.WriteLine("Before");
            Del1 obj = Display;
            obj.BeginInvoke("   with parameter ", null, null);
            Console.WriteLine("After");
            Console.ReadLine();
        }
        static void Display(string s)
        {
           System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Display" + s+"called after 1000ms");
        }
    }
}
namespace AsyncCodeWithDelegates3
{

    public delegate string Del1(string s);
    class Program
    {
        static void Main3()
        {
            Console.WriteLine("Before");
            Del1 obj = Display;
            obj.BeginInvoke("aaa", new AsyncCallback(CallbackFunction) , null);
            //cw(retval);
            Console.WriteLine("After");
            Console.ReadLine();
        }

        static void CallbackFunction(IAsyncResult ar)
        {
            Console.WriteLine("call back func called");
        }

        static string Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Display" + s);
            return s.ToUpper();
        }
    }
}

namespace AsyncCodeWithDelegates4
{

    public delegate string Del1(string s);
    class Program
    {
        static Del1 obj;
        static void Main4()
        {
            Console.WriteLine("Before");
            obj = Display;
            IAsyncResult ar = obj.BeginInvoke("  i am display", new AsyncCallback(CallbackFunction), null);


            Console.WriteLine("After");
            Console.ReadLine();
        }

        static void CallbackFunction(IAsyncResult ar)
        {
            Console.WriteLine("call back func called");
            string retval = obj.EndInvoke(ar);
            Console.WriteLine(retval);
        }

        static string Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Display" + s);
            return s.ToUpper();
        }
    }
}


namespace AsyncCodeWithDelegates5
{

    public delegate string Del1(string s);
    class Program
    {
        static void Main12()
        {
            Console.WriteLine("Before");
            Del1 obj = Display;
            //IAsyncResult ar = obj.BeginInvoke("aaa", new AsyncCallback(CallbackFunction), "some data here");
            IAsyncResult ar = obj.BeginInvoke("aaa", new AsyncCallback(CallbackFunction), obj);

            Console.WriteLine("After");
            Console.ReadLine();
        }

        static void CallbackFunction(IAsyncResult ar)
        {
            Console.WriteLine("call back func called");

            string data = ar.AsyncState.ToString();
            Console.WriteLine(data);

            Del1 obj = (Del1)ar.AsyncState;

            string retval = obj.EndInvoke(ar);
            Console.WriteLine(retval);
        }

        static string Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Display" + s);
            return s.ToUpper();
        }
            
        }
    }
          

namespace AsyncCodeWithDelegates6
{

    public delegate string Del1(string s);
    class Program
    {
        static void Main456()
        {
            Console.WriteLine("Before");
            Del1 obj = Display;
            IAsyncResult ar2 = obj.BeginInvoke("aaa", new AsyncCallback(CallbackFunction), null);

            void CallbackFunction(IAsyncResult ar)
            {
                Console.WriteLine("call back func called 123456");
                string retval = obj.EndInvoke(ar);
                Console.WriteLine(retval);
            }

            Console.WriteLine("After");
            Console.ReadLine();
        }

      
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Display" + s);
            return s.ToUpper();
        }
    }
}

namespace AsyncCodeWithDelegates7
{

    public delegate string Del1(string s);
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Before");
            Del1 obj = Display;
            IAsyncResult ar2 = obj.BeginInvoke("aaa", delegate(IAsyncResult ar)
            {
                Console.WriteLine("call back func called annanomusss");
                string retval = obj.EndInvoke(ar);
                Console.WriteLine(retval);
            }   , null);
            Console.WriteLine("After");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Display" + s);
            return s.ToUpper();
        }
    }
}


namespace AnonymousMethods
{

    public delegate void Del1();
    public delegate int Del2(int a, int b);
    public delegate int Del3(int a);
    class Program
    {
        static void Main8()
        {
            //Del1 obj = Display;
            //obj();

            int x = 100;
            Del1 obj = delegate()
            {
                x++;
                Console.WriteLine("Display" );
            };
            Del2 obj2 = delegate (int a, int b)
            {
                return a + b;
            };
            Del3 obj3 = delegate (int a){ return a * 2; };


            obj();
            Console.WriteLine(x);
            Console.WriteLine(obj2(1, 2));
            Console.WriteLine(obj3(12));

            Console.ReadLine();
        }

        //static void Display()
        //{
        //    Console.WriteLine("Display");
        //}
        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}
    }
}
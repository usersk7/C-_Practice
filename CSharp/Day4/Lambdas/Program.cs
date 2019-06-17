using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas1
{

    public delegate int Del1(int a);
    class Program
    {

        static void Main1()
        {
            Del1 obj1 = GetDouble;
            Del1 obj2 = delegate (int a) { return a * 2; };

            //Del1 obj3 = a => a * 2;
            Del1 obj3 = (a) => a * 2;


            Console.WriteLine(obj1(10));
            Console.WriteLine(obj2(20));
            Console.WriteLine(obj3(30));

            Console.ReadLine();
        }
        public delegate int Del2(int a, int b);
        public delegate bool Del3(int a, int b);
        public delegate decimal Del4(Emp obj);
        public delegate bool Del5(Emp obj);
        static void Main2()
        {
            Del2 o1 = (a, b) => a + b;
            Console.WriteLine(o1(1,2));

            Del3 o3 = (a, b) => b > a;
            Console.WriteLine(o3(1,2));

            Del4 obj4 = a => a.Basic;
            Console.WriteLine(obj4(new Emp { Basic = 1234 }));

            Del5 obj5 = a => a.Basic > 10000;
            Console.WriteLine(obj5(new Emp { Basic = 12345 }));



            Console.ReadLine();
        }

        public class Emp
        {
            public decimal Basic { get; set; }
            public string Name { get; set; }

        }
        static int GetDouble(int a)
        {
            return a * 2;
        }

    }


}

namespace Lambdas2
{

    public delegate int Del1(int a);
    class Program
    {
        public static void Main()
        {
            Action obj1 = Display;
            obj1();

            Action<string> obj2 = Display;
            obj2("aaa");

            Action<string, int> obj3 = Display;
            obj3("a", 10);


            Action obj4 = delegate () { Console.WriteLine("hello"); };
            Action obj5 = () => { Console.WriteLine("aa"); } ;
            obj4();
            obj5();



            Console.ReadLine();
        }
        public static void Main77()
        {
            Func<int, int, int> o1 = Add;
            Console.WriteLine(o1(10,20));

            //Del2 o1 = (a, b) => a + b;
            Func<int, int, int> o2 = (a, b) => a + b;
            Console.WriteLine(o2(1, 2));

            Func<int, int, bool> o3 = (a, b) => b > a;
            Console.WriteLine(o3(1, 2));

            Func<Emp , decimal> o4 = a => a.Basic;
            Console.WriteLine(o4(new Emp { Basic = 1234 }));

            Func<Emp, bool> obj5 = a => a.Basic > 10000;
            Console.WriteLine(obj5(new Emp { Basic = 12345 }));

            Predicate<Emp> obj6 = a => a.Basic > 10000;
            Console.WriteLine(obj6(new Emp { Basic = 12345 }));


            Console.ReadLine();
        }

        public static void Display()
        {
            Console.WriteLine("Display");
        }
        public static void Display(string s)
        {
            Console.WriteLine("Display" + s);
        }
        public static void Display(string s, int i)
        {
            Console.WriteLine("Display" + s + i);
        }
        public static int Add(int i, int j)
        {
            return i + j;
        }

        public delegate int Del2(int a, int b);
        public delegate bool Del3(int a, int b);
        public delegate decimal Del4(Emp obj);
        public delegate bool Del5(Emp obj);
        static void Main1432()
        {
            Del2 o1 = (a, b) => a + b;
            Console.WriteLine(o1(1, 2));

            Del3 o3 = (a, b) => b > a;
            Console.WriteLine(o3(1, 2));

            Del4 obj4 = a => a.Basic;
            Console.WriteLine(obj4(new Emp { Basic = 1234 }));

            Del5 obj5 = a => a.Basic > 10000;
            Console.WriteLine(obj5(new Emp { Basic = 12345 }));

            Console.ReadLine();
        }

        public class Emp
        {
            public decimal Basic { get; set; }
            public string Name { get; set; }

        }
        static int GetDouble(int a)
        {
            return a * 2;
        }

    }


}

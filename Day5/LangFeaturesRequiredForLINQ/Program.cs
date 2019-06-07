using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangFeaturesRequiredForLINQ
{
    class Program
    {
        //implicit variables
        static void Main1()
        {
            //int i;
            //string s;
            //decimal d;

            //used only for local variables
            //cant be used for class level vars,fn params and return types
            var i = 0;
            var s = "abc";
            Console.WriteLine(i.GetType());
            Console.ReadLine();
        }
    }
}

namespace AnonymousTypes
{
    class Program
    {
        static void Main2()
        {
            //Class1 obj = new Class1{ P1 = 10, P2=20, P3 ="abc"};
            var obj = new { P1 = 10, P2 = 20, P3 = "abc" };
            var obj2 = new { P1 = 10, P2 = 20, P3 = "qqq" };

            var obj3 = new { P2 = 20, P3 = "abc" };
            //Console.WriteLine(obj.);


            Console.WriteLine(obj.GetType().ToString());
            Console.WriteLine(obj2.GetType().ToString());
            Console.WriteLine(obj3.GetType().ToString());
            Console.ReadLine();
        }
    }
}

namespace ExtensionMethods1
{
    class Program
    {
        static void Main1()
        {
            string s = "AbCdEf", s2 ="bbb";
            //s = s.ToggleCase();
            s.Display();
            s.DisplayObject();
            MyExtClass.Display(s);
            //s2.Display();

            int i = 100;
            i.Display();
            i.DisplayObject();
            Console.ReadLine();
        }
    }

    public static class MyExtClass
    {
        public static void Display(this string s)
        {
            Console.WriteLine(s);
        }
        public static void Display(this int i)
        {
            Console.WriteLine(i);
        }
        public static void DisplayObject(this object i)
        {
            Console.WriteLine(i);
        }
        public static string ToggleCase(this string s)
        {

            string retval = "";
            for (int i = 0; i < s.Length; i++)
            {
                string temp = s.Substring(i, 1);
                if (temp == temp.ToUpper())
                    temp = temp.ToLower();
                else
                    temp = temp.ToUpper();

                retval = retval + temp;
            }
            return retval;
        }

    }


}

namespace ExtensionMethods
{
    class Program
    {
        static void Main1()
        {
            int i = 100;
            i.Method1();
            i.Method3();
            ExtMethodsClass.Method1(i);

            string s = "aaa";
            s.Method2();

            Console.ReadLine();
        }

        static void Main()
        {
            ClsMaths obj = new ClsMaths();
            Console.WriteLine(obj.Subtract(20, 10));

            Console.ReadLine();
        }
    }

    public static class ExtMethodsClass
    {
        public static void Method1(this int i)
        {
            Console.WriteLine(i);
        }
        public static void Method2(this string i)
        {
            Console.WriteLine(i);
        }
        //if you define an extension method for the base class,
        //it is also available for the derived classes
        public static void Method3(this object i)
        {
            Console.WriteLine(i);
        }
        public static int Subtract(this IMathOperations i, int a, int b)
        {
            return a - b;
        }

    }

    public interface IMathOperations
    {
        int Add(int a, int b);
        int Multiply(int a, int b);
    }
    public class ClsMaths : IMathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValue
{
    class Program
    {
        static void Main()
        {
            int a =10, b ;


            Initialize(out a, out b);
         //   Swap(ref a,ref b);
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            

            Console.ReadLine();
        }
        static void Swap(ref int a, ref int b)
        {
            Console.WriteLine("from main "+a);

            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void Initialize(out int a, out int b)
        {
          //  Console.WriteLine(a);

            a = 100;
            b = 200;
           // Console.WriteLine(a);
        }
    }
}

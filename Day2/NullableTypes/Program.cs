using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main()
        {
            int? i = 0;  //Nullable<int> i2 = 0;

            //i = 100;
            i = null;

            int j;
            //j = (int)i;
            if (i != null)
                j = (int)i;
            else
                j = 0;
            if (i.HasValue)
                j = i.Value;
            else
                j = 0;
            j = i.GetValueOrDefault();
            j = i.GetValueOrDefault(10);
            j = i ?? 10;

            Console.WriteLine(j);
            Console.ReadLine();
        }


        static void Main2()
        {
            byte b1;
            sbyte b2;
            char ch;
            short sh1;
            ushort sh2;
            int i1;
            uint i2;
            long l1;
            ulong l2;
            float f;
            double d;
            decimal d2;
            bool b;

            string s;
            object o;

        }
    }
}

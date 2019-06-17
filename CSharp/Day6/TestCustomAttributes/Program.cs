using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCustomAttributes
{
    class Program
    {
        static void Main()
        {
            Type t = typeof(Class1);
            object [] arrAttributes = t.GetCustomAttributes(false);
            foreach (Attribute a in arrAttributes)
            {
                Console.WriteLine(a.GetType().Name);
            }
            Console.ReadLine();
        }
    }
    [CreatingCustomAttributes.Attribute1("aaa")]
    class Class1
    {

    }
}

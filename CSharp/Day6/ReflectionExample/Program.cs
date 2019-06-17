using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace ReflectionExample
{
    class Program
    {
        static void Main()
        {
            Assembly asm = Assembly.LoadFile(@"C:\Vikram\Day1\BasicClassConcepts\bin\Debug\BasicClassConcepts.exe");
            Console.WriteLine(asm.FullName);
            Type[] arrTypes = asm.GetTypes();
            foreach (Type t in arrTypes)
            {
                Console.WriteLine( "   " + t.Name );
                MethodInfo[] arrMethods = t.GetMethods();
                foreach (MethodInfo m in arrMethods)
                {
                    Console.WriteLine("      " + m.Name  );
                    //m.getpa
                }
            }

            Console.ReadLine();
        }
    }
}

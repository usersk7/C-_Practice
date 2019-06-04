using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples2
{

    class Class1
    {
        private int p1;
        public int P1
        {
            private set { p1 = value; } 
            //property accessor - only one of set/get can be given and can only reduce access not increase it
            get { return p1; }
        }

        public Class1(int P1)
        {
            this.P1 = P1;
        }

    }

    class Program
    {
        static void Main()
        {
            Class1 o2 = new Class1(10);

            //o2.P1 = 100;


            //AbstractClass o = new AbstractClass();
            DerivedClass o = new DerivedClass();
            o.Display();
            Console.ReadLine();

        }
    }

    public abstract class AbstractClass
    {
        public void Display()
        {
            Console.WriteLine("abs class");
        }
    }
    public class DerivedClass : AbstractClass
    {
    }

    public abstract class AbstractClass2
    {
        public abstract void Display(); //pure virtual fn - abstract method
        public abstract void Show(); //pure virtual fn - abstract method
    }

    public class Derived2 : AbstractClass2
    {
        public override void Display()
        {
            
        }
        public override void Show()
        {
            
        }
    }

}
//to do - try a sealed class





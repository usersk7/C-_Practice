using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts
{
    class Program
    {
        static void Main1()
        {
            //System.Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
        static void Main2()
        {
            //Class1 obj;
            //obj = new Class1();
            Class1 obj = new Class1();
            obj.Display();
            obj.Display("aaa");

            int sum;
            sum = obj.Add(10, 20);
            Console.WriteLine(sum);
            sum = obj.Add(10);
            Console.WriteLine(sum);
            sum = obj.Add();
            Console.WriteLine(sum);


            //sum = obj.Add(0, 0, 30);
            sum = obj.Add(c: 30);  //named parameters
            sum = obj.Add(c:30,b:20);  //named parameters
            Console.WriteLine(sum);

            Console.ReadLine();
        }

        static void Main()
        {
            //int i;
            //Console.WriteLine(i);
            Class1 obj = new Class1();
            //obj.i = 100;
            //Console.WriteLine(obj.i);
            obj.Seti(100);
            Console.WriteLine(obj.Geti());


            obj.P1 = 100;
            Console.WriteLine(obj.P1);

            obj.P2 = 12345;
            Console.WriteLine(obj.P2);
            Console.ReadLine();
        }
    }

    public class Class1
    {
        #region Methods
        public void Display()
        {
            Console.WriteLine("Display");
        }
        public void Display(string s)
        {
            Console.WriteLine("Display" + s);
        }
        //public void Display(string s="")
        //{
        //    Console.WriteLine("Display" + s);
        //}

        public int Add(int a=0, int b=0,int c=0)
        {
            return a + b + c;
        }

        #endregion
        #region Variables/(Fields)
        private int i=1;
        public void Seti(int Value)
        {
            if (Value >= 1 && Value <= 86)
                i = Value;
            else
            {
                //throw an exception
                Console.WriteLine("Invalid value");
            }
        }
        public int Geti()
        {
            return i;
        }

        #endregion

        #region Properties

        private int p1;
        public int P1
        {
            set
            {
                if (value < 100)
                    p1 = value;
                else
                    Console.WriteLine("Invalid value");

            }
            get
            {
                return p1;
            }
        }
        //to do --- create readonly property
        //to do --- create writeonly property

        private int p2;
        public int P2
        {
            set { p2 = value; }
            get { return p2; }

        }

        //automatic property --- compiler generates a private variable and also code for get and set
        public int P3
        { set; get; }

        #endregion

    }


}


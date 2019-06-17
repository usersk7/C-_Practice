using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            Class1 o = new Class1();

            o[0] = 100;
            o[1] = 200;
            o[2] = 300;
            Console.WriteLine();
            Console.WriteLine( o[1]);

            //o.Display();
            Console.ReadLine();
        }

        static void Main2()
        {
            YearlyRainfall obj = new YearlyRainfall(3,2000);
            obj[2000] = 10000;
            obj[2001] = 20000;
            obj[2002] = 30000;

            Console.WriteLine(obj[2000]);

            Console.ReadLine();
        }
    }
    public class Class1
    {
        int[] arr = new int[5];

        public int this[int subscript]
        {
            set
            {               arr[subscript] = value;           }
            get
            { return arr[subscript]; }
        }
        public void Display()
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

        }
    }
    public class YearlyRainfall
    {
        int[] arr ;
        int start;
        public YearlyRainfall(int no_of_years, int start)
        {
            this.start = start;
            arr = new int[no_of_years];
        }
        public int this[int subscript]
        {
            set
            {
                arr[subscript-start] = value;
            }
            get
            {
                return arr[subscript-start];
            }
        }
        public void Display()
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

        }
    }
}

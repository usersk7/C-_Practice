using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes1
{
    class Program
    {
        static void Main1()
        {
            MyPoint p = new MyPoint();
           // MyPoint p;
            p.X = 100;
            p.Y = 200;
            Console.WriteLine(p.X);
            Console.WriteLine(p.Y);
            //int i = 0;
            int i = new int();
            Console.WriteLine(i);

            Console.ReadLine();
        }
    }
    public struct MyPoint
    {
        public int X, Y;
        public MyPoint(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}


namespace ValueTypes2
{
    class Program
    {
        static void Main()
        {
            //DisplayGreeting(1);
            DisplayGreeting2( TimeOfDay.Morning);
            Console.ReadLine();
        }

        static void DisplayGreeting2(TimeOfDay t)
        {
            if (t == TimeOfDay.Morning )
                Console.WriteLine("Good morning");
            else if (t == TimeOfDay.Afternoon)
                Console.WriteLine("Good afternoon");
            else if (t == TimeOfDay.Evening)
                Console.WriteLine("Good evening");
            else if (t == TimeOfDay.Night)
                Console.WriteLine("Good night");
        }


        static void DisplayGreeting(int timeofday)
        {
            if (timeofday == 0)
                Console.WriteLine("Good morning");
            else if (timeofday == 1)
                Console.WriteLine("Good afternoon");
            else if (timeofday == 2)
                Console.WriteLine("Good evening");
            else if (timeofday == 3)
                Console.WriteLine("Good night");
        }
    }

    //public enum TimeOfDay
    public enum TimeOfDay :short
    {
        Morning = 10,
        Afternoon =20,
        Evening,
        Night
    }

}


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExample
{
    class Program
    {
        static void Main1()
        {
            ArrayList obj = new ArrayList();
            obj.Add(10);  //object = int;
            obj.Add("aaa"); 
            obj.Add(false);
            obj.Add(20);
            obj.Add("bbb");
            obj.Add(false);

            obj.Remove(10);
            obj.RemoveAt(0);

            foreach (object o in obj)
            {
                Console.WriteLine(o);
            }

            Console.ReadLine();
        }
        static void Main()
        {
            //Hashtable h = new Hashtable();
            SortedList h = new SortedList();
            h.Add("a", "A data");
            h.Add("b", "B data");
            h.Add("c", "C data");
            //h.Add("c", "C data new");
            h.Add("d", "D data");
            h.Add("e", "E data");
            h.Add("f", "F data");

            h["c"] = "New c data";
            h["x"] = "x data";


            foreach (DictionaryEntry de in h)
                Console.WriteLine(de.Key + ":" + de.Value);


            Console.ReadLine();
        }

        static void Main3()
        {
            Queue q = new Queue();

            //q.Peek
            q.Enqueue("aaa");
            q.Dequeue();


            Stack st = new Stack();

            st.Push();
            st.Pop();
        }
    }

}

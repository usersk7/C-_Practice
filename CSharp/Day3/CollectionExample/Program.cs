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
        static void Main44()
        {
          //  Hashtable h = new Hashtable();
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
            //q.Enqueue("aaa");
            //q.Dequeue();


            //Stack st = new Stack();

            //st.Push();
            //st.Pop();
        }

        static void Main4()
        {
            List<int> obj = new List<int>();
            obj.Add(10);
            obj.Add(20);
            foreach (int i in obj )
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        static void Main5()
        {
            SortedList<int, string> objSortedList = new SortedList<int, string>();


            objSortedList.Add(1, "aa");
            objSortedList[2] = "bb";
            foreach (KeyValuePair<int, string> objKvp in objSortedList)
            {
                Console.WriteLine(objKvp.Key);
                Console.WriteLine(objKvp.Value);
            }
            Console.ReadLine();

            //Queue<int> q = new Queue<int>();
            //q.Enqueue()
            //Stack<int> s = new Stack<int>();
            //s.Push(10)

        }
        static void Main6()
        {
            //List<int> obj = new List<int>();
            //obj.Add(10);
            //obj.Add(20);
            //foreach (int i in obj)
            //{
            //    Console.WriteLine(i);
            //}
            Employees objEmps = new Employees();

            //List<Employee> objEmps = new List<Employee>();
            objEmps.Add(new Employee { Empno = 1, Name = "a" });
            objEmps.Add(new Employee { Empno = 2, Name = "b" });
            objEmps.Add(new Employee { Empno = 3, Name = "c" });
            objEmps.Add(new Employee { Empno = 4, Name = "d" });
            foreach (Employee e in objEmps)
            {
                Console.WriteLine( e.Name );
            }

            Console.ReadLine();
        }

        static void Main()
        {
            Employees2 objSortedList = new Employees2();
            //SortedList<int, Employee> objSortedList = new SortedList<int, Employee>();
            objSortedList.Add(1, new Employee { Empno = 1, Name = "a" });
            objSortedList.Add(2, new Employee { Empno = 2, Name = "b" });
            objSortedList.Add(3, new Employee { Empno = 3, Name = "c" });

            foreach (KeyValuePair<int,Employee> objKvp in objSortedList  )
            {
                Console.Write(objKvp.Key);
                Console.Write(objKvp.Value.Empno);
                Console.WriteLine(objKvp.Value.Name);
            }
            Console.ReadLine();
        }
    }
    public class Employees2 : SortedList<int, Employee> { }
    public class Employees : List<Employee>
    {
    }

    public class Employee
    {
        private int empno;
        public int Empno
        {
            get { return empno; }
            set { empno = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

}

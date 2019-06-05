using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Program
    {
        static void Main()
        {
            //IntegerStack obj = new IntegerStack(5);
            //obj.Push(10);
            //Console.WriteLine(obj.Pop());

            MyStack<int> obj = new MyStack<int>(3);
            obj.Push(10);
            obj.Push(20);
            obj.Push(30);
            //obj.Push(40);

            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());
            //Console.WriteLine(obj.Pop());


            MyStack<string> obj2 = new MyStack<string>(3);
            obj2.Push("10");
            obj2.Push("20");
            obj2.Push("30");

            Console.WriteLine(obj2.Pop());
            Console.WriteLine(obj2.Pop());
            Console.WriteLine(obj2.Pop());

            Console.ReadLine();
        }
    }

    class IntegerStack
    {
        int[] arr;
        public IntegerStack(int Size)
        {
            arr = new int[Size];
        }
        int Pos = -1;
        public void Push(int i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack full");
            arr[++Pos] = i;
        }
        public int Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack Empty");
            return arr[Pos--];
        }
    }
    class StringStack
    {
        string[] arr;
        public StringStack(int Size)
        {
            arr = new string[Size];
        }
        int Pos = -1;
        public void Push(string i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack full");
            arr[++Pos] = i;
        }
        public string Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack Empty");
            return arr[Pos--];
        }
    }

    class MyStack<T> 
        //where T : struct
    {
        T[] arr;
        public MyStack(int Size)
        {
            arr = new T[Size];
        }
        int Pos = -1;
        public void Push(T i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack full");
            arr[++Pos] = i;
        }
        public T Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack Empty");
            return arr[Pos--];
        }
    }


}

//Generic Constraints
//where T : class  --- T must be a reference type
//where T : struct  --- T must be a value type
//where T : ClassName --- T must be that class or its derived classes
//where T : InterfaceName --- T must be a class that implements that interface
//where T : new() --- T must have a no parameter constructor

//where T : ClassName, InterfaceName
//where T : ClassName, InterfaceName, new()


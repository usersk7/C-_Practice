using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//in this example single interfaces are created 
namespace Interfaces1
{
    class Program
    {
        static void Main11()
        {
            Class1 o = new Class1();
            o.Delete();

            //method 2
            IDbFunctions oIDb;
            oIDb = o;
            oIDb.Delete();

            //method 3
            ((IDbFunctions)o).Delete();

            Console.ReadLine();
        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }
    //knljfdfnjdddjnahsandassjan

    public class Class1 : IDbFunctions
    {
        public void Display()
        {
            Console.WriteLine("Class1 Display");

        }

        public void Delete()
        {
            Console.WriteLine("Class1 IDb.Delete") ;
        }

        public void Insert()
        {
            Console.WriteLine("Class1 IDb.Insert");
        }

        public void Update()
        {
            Console.WriteLine("Class1 IDb.Update");
        }
    }
}

//in this example two interfaces are created 
namespace Interfaces2
{
    class Program
    {
        
        static void Main1()
        {
            Class1 o = new Class1();

            //method 2
            IDbFunctions oIDb;
            oIDb = o;
            oIDb.Delete();

            IFileFunctions oIFile;
            oIFile = o;
            oIFile.Delete();

            //method 3
            ((IDbFunctions)o).Delete();
            ((IFileFunctions)o).Delete();

            Console.ReadLine();
        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }
    public interface IFileFunctions
    {
        void Open();
        void Close();
        void Delete();
    }
    public class Class1 : IDbFunctions, IFileFunctions
    {
        public void Display()
        {
            Console.WriteLine("Class1 Display");

        }

        void IDbFunctions.Delete()   //if class having two interface as---->> interfacename.methodname
        {
            Console.WriteLine("Class1 IDb.Delete");
        }

        public void Insert()
        {
            Console.WriteLine("Class1 IDb.Insert");
        }

        public void Update()
        {
            Console.WriteLine("Class1 IDb.Update");
        }

        //void IFileFunctions.Open()
        //{
        //    Console.WriteLine("Class1 Ifile.Open");
        //}

        //void IFileFunctions.Close()
        //{
        //    Console.WriteLine("Class1 Ifile.Close");
        //}

        void IFileFunctions.Delete()
        {
            Console.WriteLine("Class1 Ifile.Delete");
        }

        public void Open()
        {
            Console.WriteLine("Class1 Ifile.Open");

        }

        public void Close()
        {
            Console.WriteLine("Class1 Ifile.Close");
        }

    }
}


//two class ARE using same interface 
namespace Interfaces3
{
    class Program
    {
        static void Main3()
        {


            Class1 obj1 = new Class1();
            Class2 obj2 = new Class2();

            //obj1.Insert();
            //obj2.Insert();

            IDbFunctions objIDb;

            objIDb = obj1;
            objIDb.Insert();

            objIDb = obj2;
            objIDb.Insert();

            Console.ReadLine();
        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }

    public class Class1 : IDbFunctions
    {
        public void Display()
        {
            Console.WriteLine("Class1 Display Called"); ;
        }

        public void Delete()
        {
            Console.WriteLine("class1 IdbFunctions.Delete Called"); ;
        }

        public void Insert()
        {
            Console.WriteLine("class1 IdbFunctions.Insert Called"); ;
        }

        public void Update()
        {
            Console.WriteLine("class1 IdbFunctions.Update Called"); ;
        }
    }
    public class Class2 : IDbFunctions
    {
        public void Show()
        {
            Console.WriteLine("Class2 Display Called"); ;
        }

        public void Delete()
        {
            Console.WriteLine("class2 IdbFunctions.Delete Called"); ;
        }

        public void Insert()
        {
            Console.WriteLine("class2 IdbFunctions.Insert Called"); ;
        }

        public void Update()
        {
            Console.WriteLine("class2 IdbFunctions.Update Called"); ;
        }
    }

}


namespace Interfaces4
{
    class Program
    {
        static void Main11()
        {

            Class1 obj1 = new Class1();
            Class2 obj2 = new Class2();
            CallInsert(obj1);
            CallInsert(obj2);
            Console.ReadLine();
        }
        static void CallInsert(IDbFunctions objIDb) //passing diffrent class object to the same type of iterface
        {
            objIDb.Insert();
        }

    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }

    public class Class1 : IDbFunctions
    {
        public void Display()
        {
            Console.WriteLine("Class1 Display Called"); ;
        }

        public void Delete()
        {
            Console.WriteLine("class1 IdbFunctions.Delete Called"); ;
        }

        public void Insert()
        {
            Console.WriteLine("class1 IdbFunctions.Insert Called"); ;
        }

        public void Update()
        {
            Console.WriteLine("class1 IdbFunctions.Update Called"); ;
        }
    }
    public class Class2 : IDbFunctions
    {
        public void Show()
        {
            Console.WriteLine("Class2 Display Called"); ;
        }

        public void Delete()
        {
            Console.WriteLine("class2 IdbFunctions.Delete Called"); ;
        }

        public void Insert()
        {
            Console.WriteLine("class2 IdbFunctions.Insert Called"); ;
        }

        public void Update()
        {
            Console.WriteLine("class2 IdbFunctions.Update Called"); ;
        }
    }

}


namespace Interfaces5
{
    class Program
    {
        static void Main()
        {
            Class1 o = new Class1();

            //use the object here

            o.Dispose();
            o.Display();
            Console.ReadLine();
        }
        static void Main1()
        {
            using (Class1 o = new Class1())
            {
                o.Display();
                //use the object here
            }
            Console.ReadLine();
        }
    }


    public class Class1 : IDisposable   
    {
        private bool isDisposed;
        public void Display()
        {
            CheckDisposed();
            Console.WriteLine("Class1 Display");
        }

        public void Dispose()
        {
            CheckDisposed();
            //write code here to free resources instead of writing it in the destructor
            Console.WriteLine("dispose called");
            isDisposed = true;
        }

        private void CheckDisposed()
        {
            if (isDisposed)
                //throw new Exception("ObjectDisposed");
               throw new ObjectDisposedException("Class1");
            
        }
    }
}


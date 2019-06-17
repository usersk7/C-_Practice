using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassesAndMethods
{
    class Program
    {
        static void Main1()
        {
            C1 o = new C1();

            Console.ReadLine();
        }
    }
    //public class C1
    //{
    //    public int i;
    //    public int j;
    //    public int k;
    //}

   
    public partial class C1
    {
        public int j;
    }
    
}

namespace PartialMethods
{
    class Program
    {
        public static void Main()
        {
            Class1 obj = new Class1();
            Console.WriteLine(obj.Check());
            Console.ReadLine();
        }
    }
    //Partial methods can only be defined within a partial class.
    //Partial methods are always implicitly private.
    //Partial methods must return void.
    //Partial methods can be static or instance level.
    //Partial methods cannnot have out params
    public partial class Class1
    {
        private bool isValid = true;
        partial void Validate();
        public bool Check()
        {
            Validate();
            return isValid;
        }
    }

    public partial class Class1
    {
        partial void Validate()
        {
            //perform some validation code here
            isValid = false;
        }
    }

}

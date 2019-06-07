using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling1
{
    class Program
    {
        static void Main1()
        {
            Class1 o = new Class1();
            try
            {
                o = null;
                o.P1 = 100 / Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("No exceptions");
            }
            catch 
            {
                Console.WriteLine("exception occured");
            }


            Console.ReadLine();

        }

        static void Main2()
        {
            Class1 o = new Class1();
            try
            {
                o = null;
                o.P1 = 100 / Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("No exceptions");
            }
            
            catch (FormatException ex)
            {
                Console.WriteLine("format exception occured");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("n.r. exception occured");
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("dbz exception occured");
            //}
            catch (SystemException ex)
            {
                Console.WriteLine("dbz exception occured");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
        static void Main3()
        {
            Class1 o = new Class1();
            try
            {
               // o = null;
                o.P1 = 100 / Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("No exceptions");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("format exception occured...enter only numbers");
                try
                {
                    o.P1 = 100 / Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("no more chances" );
                }

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("n.r. exception occured");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("dbz exception occured");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                Console.WriteLine("finally");
            }


            Console.ReadLine();

        }

    }

    class Class1
    {
        private int p1;
        public int P1
        {
            get { return p1; }
            set
            {
                p1 = value;

            }
        }

    }

}
namespace ExceptionHandling2
{
    class Program
    {
        static void Main()
        {
            Class1 o = new Class1();
            try
            {
                //o = null;
                o.P1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("No exceptions");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("format exception occured");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("n.r. exception occured");
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("dbz exception occured");
            //}
            catch (InvalidP1Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }

    }

    class Class1
    {
        private int p1;
        public int P1
        {
            get { return p1; }
            set
            {
                if (value > 0)
                    p1 = value;
                else
                {
                    //Exception ex = new Exception();
                    //throw ex;

                    //throw new Exception();
                    //throw new Exception("invalid value");
                    throw new InvalidP1Exception("invalid value");
                }

            }
        }

    }
    public class InvalidP1Exception : Exception
    {
        public InvalidP1Exception(string message) :  base(message)
        {
            
        }

    }

}

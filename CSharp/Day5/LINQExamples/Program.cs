using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    class Program
    {
        static List<Employee> lstEmp = new List<Employee>();
        static List<Department> lstDept = new List<Department>();

        static Employee GetEmp1(Employee o)
        {
            return o;
        }
        static void Main()
        {
            AddRecs();
            //var emps = lstEmp.Select(GetEmp1);
            var emps = lstEmp.Select(emp => emp);
            var emps2 = lstEmp.Select(emp => emp.Name);
            var emps3 = lstEmp.Select(emp => emp.Basic);
            var emps4 = lstEmp.Select(emp =>  new { emp.EmpNo, emp.Name} );

            var emps5 = lstEmp.Select(emp => emp).Where(emp => emp.Basic > 10000);
            var emps6 = lstEmp.Where(emp => emp.Basic > 10000);
            var emps7 = lstEmp.Where(emp => emp.Name.StartsWith("V"));
            var emps8 = lstEmp.Select(emp=> emp.Name).Where(name => name.StartsWith("V"));
            var emps9 = lstEmp.Select(emp => emp).OrderBy(emp => emp.Name);
            var emps10 = lstEmp.Select(emp => emp).OrderBy(emp => emp.Name).OrderBy(emp => emp.Basic);
            var emps11 = lstEmp.Select(emp => emp).OrderBy(emp => emp.Name).OrderByDescending(emp => emp.Basic);



            foreach (var item in emps9)
            {
                //Console.WriteLine(item.);
                Console.WriteLine(item.Name + " : " + item.EmpNo);
            }
            Console.ReadLine();
        }
        static string GetEmp2(Employee o)
        {
            return o.Name;
        }
        static void Main77()
        {
            AddRecs();

            var emps = lstEmp.Select(GetEmp2);

            foreach (var item in emps)
            {
                //Console.WriteLine(item.);
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static void Main1()
        {
            AddRecs();
            //IEnumerable<Employee> emps = from emp in lstEmp select emp;
            var emps = from emp in lstEmp select emp;

            lstEmp.RemoveAt(0);
            lstEmp.RemoveAt(0);

            //var emps = from emp in lstEmp select new { emp.Name, emp.EmpNo };
            //var emps = from emp in lstEmp select emp.Basic;

            //from single_object in collection select expression
            foreach (var item in emps)
            {
                //Console.WriteLine(item.);
                Console.WriteLine(item.Name + " : " + item.EmpNo);
            }
            //lstEmp.RemoveAt(0);
            //lstEmp.RemoveAt(0);

            //foreach (var item in emps)
            //{
            //    //Console.WriteLine(item.);
            //    Console.WriteLine(item.Name + " : " + item.EmpNo);
            //}

            //Console.WriteLine();
            //lstEmp.RemoveAt(0);
            //foreach (var item in emps)
            //{
            //    //Console.WriteLine(item);
            //    Console.WriteLine(item.Name + " : " + item.Basic);
            //}

            Console.ReadLine();
        }
        static void Main2()
        {
            AddRecs();
            var emps = from emp in lstEmp
                       select emp.Basic;
            //var emps = from emp in lstEmp
            //           select emp.Name, emp.Basic;

            foreach (var item in emps)
                Console.WriteLine(item);

            Console.ReadLine();
        }
        static void Main3()
        {
            AddRecs();
            var emps = from emp in lstEmp
                       select new { emp.Name, emp.Basic };
            foreach (var item in emps)
                Console.WriteLine(item.Basic);

            Console.ReadLine();
        }
        static void Main6666666666()
        {
            AddRecs();
            var emps = from emp in lstEmp
                       where emp.Basic > 10000
                       select emp;
            //var emps = from emp in lstEmp
            //           where emp.Basic > 10000 && emp.Basic < 12000
            //           select emp;

            //var emps = from emp in lstEmp
            //           where emp.Basic == 10000 || emp.Basic == 12000
            //           select emp;
            //var emps = from emp in lstEmp
            //           where emp.Name.StartsWith("V")
            //           select emp;

            foreach (var item in emps)
                Console.WriteLine(item.Name + " : " + item.Basic);

            Console.ReadLine();
        }
        static void Main5()
        {
            AddRecs();
            //var emps = from emp in lstEmp
            //           where (emp.EmpNo < 5 || emp.Basic == 10000)
            //           orderby emp.Name
            //           select emp;
            //var emps = from emp in lstEmp
            //           orderby emp.Name
            //           select emp;
            //var emps = from emp in lstEmp
            //           orderby emp.Name ascending
            //           select emp;

            //var emps = from emp in lstEmp
            //           orderby emp.Name descending
            //           select emp;

            //var emps = from emp in lstEmp
            //           orderby emp.DeptNo ascending, emp.Name descending
            //           select emp;
            //foreach (var item in emps)
            //    Console.WriteLine(item.Name + " : " + item.Basic + ":" + item.DeptNo);

            var emps = from emp in lstEmp
                       join dept in lstDept
                             on emp.DeptNo equals dept.DeptNo
                       select new { dept.DeptName, emp.Name };

            foreach (var item in emps)
                Console.WriteLine(item.DeptName+ " : " + item.Name);

            Console.ReadLine();
        }
        static void Main6()
        {
            AddRecs();
            var emps = from emp in lstEmp
                       join dept in lstDept
                             on emp.DeptNo equals dept.DeptNo
                       select new { dept.DeptName, emp.Name };

            foreach (var item in emps)
                Console.WriteLine(item.DeptName + " : " + item.Name);

            Console.ReadLine();
        }
        static Employee F1(Employee o)
        {
            return o;
        }
        static string F2(Employee o)
        {
            return o.Name;
        }
        static bool WhereFunc(Employee o)
        {
            //if (o.Basic > 10000)
            //    return true;
            //else
            //    return false;
            return (o.Basic > 10000);
        }

        static void Main111()
        {
            AddRecs();
            var e2 = lstEmp.Select(F1);
            var e3 = lstEmp.Select(F2);
            var e4 = lstEmp.Select(delegate (Employee o)
            {
                return o;
            });
            var e5 = lstEmp.Select(o => o);
            var e6 = lstEmp.Select(o => o.Name);
            var e7 = lstEmp.Select(o => new { o.Name, o.EmpNo });




            var emps = lstEmp.Select(emp => emp);
            //var emps2 = lstEmp.Select(emp => emp.Basic);
            //var emps3 = lstEmp.Select(emp => new { emp.EmpNo, emp.Name});


            foreach (var item in emps)
                Console.WriteLine(item.EmpNo + " : " + item.Name);

            Console.ReadLine();
        }
        static void Main3333333333()
        {
            AddRecs();
            var emp2 = lstEmp.Where(WhereFunc);
            var emp21 = lstEmp.Where(o => o.Basic > 10000).Select(o => o.Name);
            //var emps = lstEmp.Where(emp => emp.EmpNo > 5).Select(emp => emp);
            var emps = lstEmp.Where(emp => emp.EmpNo > 5);

            foreach (var item in emp2)
                Console.WriteLine(item.EmpNo + " : " + item.Name);

            Console.ReadLine();
        }

        static void Main12()
        {
            AddRecs();
            var emps = lstEmp.OrderBy(emp => emp.DeptNo).OrderBy(emp => emp.Basic).OrderBy(emp => emp.Name);
            var emps2 = lstEmp.OrderByDescending(emp => emp.Basic);

            foreach (var item in emps)
                Console.WriteLine(item.EmpNo + " : " + item.Name);

            Console.ReadLine();
        }

        static void Main1dsfdsafdsaf()
        {
            //    var emps = from emp in lstEmp
            //               join dept in lstDept
            //                     on emp.DeptNo equals dept.DeptNo
            //               select new { dept.DeptName, emp.Name };
            AddRecs();


            var emps = lstEmp.Join(lstDept, emp => emp.DeptNo, dep => dep.DeptNo, (emp, dep) => new { emp.Name, dep.DeptName });
            var emps2 = lstEmp.Join(lstDept, emp => emp.DeptNo, dep => dep.DeptNo, (emp, dep) => emp);
            var emps3 = lstEmp.Join(lstDept, emp => emp.DeptNo, dep => dep.DeptNo, (emp, dep) => dep);
            var emps4 = lstEmp.Join(lstDept, emp => emp.DeptNo, dep => dep.DeptNo, (emp, dep) => emp.Name);
            var emps5 = lstEmp.Join(lstDept, emp => emp.DeptNo, dep => dep.DeptNo, (emp, dep) => dep.DeptName);
            var emps6 = lstEmp.Join(lstDept, emp => emp.DeptNo, dep => dep.DeptNo, (emp, dep) => new { emp.Name, dep.DeptName });
            foreach (var item in emps)
                Console.WriteLine(item.Name + " : " + item.DeptName);

            Console.ReadLine();
        }


        public class Department
        {
            public int DeptNo { get; set; }
            public string DeptName { get; set; }
        }
        public class Employee
        {
            public int EmpNo { get; set; }
            public string Name { get; set; }
            public decimal Basic { get; set; }
            public int DeptNo { get; set; }
            public string Gender { get; set; }
        }

        public static void AddRecs()
        {
            lstDept.Add(new Department { DeptNo = 10, DeptName = "SALES" });
            lstDept.Add(new Department { DeptNo = 20, DeptName = "MKTG" });
            lstDept.Add(new Department { DeptNo = 30, DeptName = "IT" });
            lstDept.Add(new Department { DeptNo = 40, DeptName = "HR" });

            lstEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 2, Name = "Vikas", Basic = 11000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 4, Name = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 5, Name = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 7, Name = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 8, Name = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
        }
    }

}

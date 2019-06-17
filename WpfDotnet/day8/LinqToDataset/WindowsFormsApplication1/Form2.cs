using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.MyTypedDsTableAdapters;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        MyTypedDs ds = new MyTypedDs();

        private void Form2_Load(object sender, EventArgs e)
        {
            DepartmentsTableAdapter daDeps = new DepartmentsTableAdapter();
            daDeps.Fill(ds.Departments);
            EmployeesTableAdapter daEmps = new EmployeesTableAdapter();
            daEmps.Fill(ds.Employees);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           var recs = ds.Employees.AsEnumerable();
            var emps = from emp in recs
                       where emp.Basic > 1000
                       select emp;
            DataTable dt = emps.CopyToDataTable();

            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var recs = ds.Employees.AsEnumerable();
            var emps = recs.Where(emp => emp.Basic > 10000).Select(emp => new { emp.EmpNo, emp.Basic });
            DataTable dt = emps.ToDataTable();

            dataGridView1.DataSource = dt;

        }
    }
}

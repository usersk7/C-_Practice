using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=.;Integrated Security=true;Initial Catalog=Suraj ");
        
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();

        private void Form1_Load(object sender, EventArgs e)
        {

            cn.Open();    
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = cn;
            cmdSelect.CommandType = CommandType.StoredProcedure;
            cmdSelect.CommandText = "SelectEmployees";

            da.SelectCommand = cmdSelect;
            da.Fill(ds, "Emps");

            cmdSelect.CommandType = CommandType.Text;
            cmdSelect.CommandText = "Select* from Departments";
            da.Fill(ds, "Deps");

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //asEnumerable converts ds.table to ienumerable<t> collection
            var recs=ds.Tables["Emps"].AsEnumerable();
            //recs have collection of data row

            //emp is single row in datarow collection

            var emps = from emp in recs
                       where emp.Field<Decimal>("Basic") > 1000
                       select emp;

            DataTable dt = emps.CopyToDataTable();
            
            dataGridView1.DataSource =dt ;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //create new table
            //loop through emps
            //add rows to this table here rows have number and basic

            var recs = ds.Tables["Emps"].AsEnumerable();
            var emps = from emp in recs
                       where emp.Field<Decimal>("Basic") > 10000
                       select new { number = emp.Field<int>("EmpNo"), basic = emp.Field<Decimal>("Basic") };

            DataTable dt = emps.ToDataTable();

            dataGridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var recs = ds.Tables["Emps"].AsEnumerable();
            var emps = from emp in recs
                       where emp.Field<Decimal>("Basic") > 10000
                       select new { number = emp.Field<int>("EmpNo"), basic = emp.Field<Decimal>("Basic") };

            DataTable dt = new DataTable();
            dt.Columns.Add("Basic", Type.GetType("System.Decimal"));
            dt.Columns.Add("EmpNo", Type.GetType("System.Int32"));

            foreach (var item in emps)
                dt.Rows.Add(item.basic, item.number);

            dataGridView1.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


       
     
    }
    public static class ListHelper
    {
        public static DataTable ToDataTable<T>(this IEnumerable<T> list)
        {
            DataTable dt = new DataTable();
            Type listType = list.ElementAt(0).GetType();
            //get element properties nad datatable columns 
            PropertyInfo[] properties = listType.GetProperties();

            foreach (PropertyInfo property in properties)
                dt.Columns.Add(new DataColumn() { ColumnName = property.Name });
            foreach (object item in list)
            {
                DataRow dr = dt.NewRow();
                foreach (DataColumn col in dt.Columns)
                    dr[col] = listType.GetProperty(col.ColumnName).GetValue(item, null);
                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}

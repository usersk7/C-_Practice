using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DotnetTraining;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds, "Emps");

            cmd.CommandText = "select * from Departments";
            da.Fill(ds, "Deps");


            //primary key constraint
            DataColumn[] arrCols = new DataColumn[1];
            arrCols[0] = ds.Tables["Emps"].Columns["EmpNo"];
            ds.Tables["Emps"].PrimaryKey = arrCols;

            //foreign key constraint
            ds.Relations.Add("DepsEmps",
                ds.Tables["Deps"].Columns["DeptNo"], 
                ds.Tables["Emps"].Columns["DeptNo"], true);

            //column level constraints
            ds.Tables["Deps"].Columns["DeptName"].Unique = true;

            //MessageBox.Show(ds.Tables.Count.ToString());

            //dgEmps.ItemsSource = ds.Tables["Deps"].DefaultView;
            dgEmps.ItemsSource = ds.Tables["Emps"].DefaultView;
            //dgEmps.ItemsSource = ds.Tables[0].DefaultView;

            cn.Close();

        }

        private void DataTableExample(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DotnetTraining;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.TableName = "Emps";
            dgEmps.ItemsSource = dt.DefaultView;
            cn.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DotnetTraining;Integrated Security=True";
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = cn;
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = "update Employees set Name=@Name, Basic =@Basic, DeptNo=@DeptNo where EmpNo = @EmpNo";

            //SqlParameter p = new SqlParameter();
            //p.ParameterName = "@Name";
            //p.SourceColumn = "Name";
            //p.SourceVersion = DataRowVersion.Current;
            //cmdUpdate.Parameters.Add(p);
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });

            da.UpdateCommand = cmdUpdate;

            //code for InsertCommand goes here

            //code for DeleteCommand goes here

            da.Update(ds, "Emps");

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //DataView dv = new DataView(ds.Tables["Emps"]);
            //dv.RowFilter = "DeptNo=" + txtDeptNo.Text;
            //dgEmps.ItemsSource = dv;


            ds.Tables["Emps"].DefaultView.RowFilter = "DeptNo=" + txtDeptNo.Text;
            //ds.Tables["Emps"].DefaultView.Sort = txtDeptNo.Text;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            ds.WriteXmlSchema("a.xsd");
            ds.WriteXml("a.xml", XmlWriteMode.DiffGram);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            ds = new DataSet();
            ds.ReadXmlSchema("a.xsd");
            ds.ReadXml("a.xml", XmlReadMode.DiffGram);
            dgEmps.ItemsSource = ds.Tables["Emps"].DefaultView;
        }
    }
}

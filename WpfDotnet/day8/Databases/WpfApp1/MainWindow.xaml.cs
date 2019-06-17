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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DotnetTraining;Integrated Security=True";
            //cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DotnetTraining;User Id=sa;Password=sa";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "insert into Employees values(10,'new emp', 10000,10)";
            cmd.CommandText = "insert into Employees values(" + txtEmpNo.Text + ",'"  
                + txtName.Text + "'," + txtBasic.Text +  "," + txtDeptNo.Text +")";
            MessageBox.Show(cmd.CommandText);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DotnetTraining;Integrated Security=True";
            //cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DotnetTraining;User Id=sa;Password=sa";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";
            cmd.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Basic", txtBasic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);
            cmd.ExecuteNonQuery();

            cn.Close();

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DotnetTraining;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertEmployee";
            cmd.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Basic", txtBasic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);
            cmd.ExecuteNonQuery();

            cn.Close();


        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DotnetTraining;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from Employees";
            int count = (int)cmd.ExecuteScalar();
            MessageBox.Show(count.ToString());

            //cmd.CommandText = "select * from Employees";
            //MessageBox.Show(cmd.ExecuteScalar().ToString());

            cn.Close();


        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DotnetTraining;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";

            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                //lstEmployees.Items.Add(new ListBoxItem { Content = dr[1] });
                lstEmployees.Items.Add(new ListBoxItem { Content = dr["Name"].ToString() });
                //lstEmployees.Items.Add(new ListBoxItem { Content = dr["EmpNo"].ToString() + dr["Name"].ToString() });
            }

            cn.Close();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DotnetTraining;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees;select * from Departments";

            SqlDataReader dr = cmd.ExecuteReader();
            lstEmployees.Items.Add(new ListBoxItem { Content = "EMPLOYEES" });
            while (dr.Read())
            {
                lstEmployees.Items.Add(new ListBoxItem { Content = "   " +dr["Name"].ToString() });
            }

            dr.NextResult();
            lstEmployees.Items.Add(new ListBoxItem { Content = "DEPARTMENTS" });
            while (dr.Read())
            {
                lstEmployees.Items.Add(new ListBoxItem { Content = "   " + dr["DeptName"].ToString() });
            }

            cn.Close();

        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DotnetTraining;Integrated Security=True";
            cn.Open();

            SqlTransaction t = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = t;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Employees values(100,'okay',12345,10)";

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = cn;
            cmd2.Transaction = t;
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "insert into Employees values(200,'okay',12345,10)";

            try
            {
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                t.Commit();
                MessageBox.Show("Commit");
            }
            catch (Exception ex)
            {
                t.Rollback();
                MessageBox.Show("Rollback");

            }


            cn.Close();


        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DotnetTraining;Integrated Security=True";
            //cn.Open();
            //Task t1 = cn.OpenAsync();
            //other code goes here

            //await t1;

            SqlCommand cmd = new SqlCommand();

            //cmd.ExecuteNonQueryAsync()


            //cmd.BeginExecuteNonQuery()
            //cmd.EndExecuteNonQuery

        }
    }
}

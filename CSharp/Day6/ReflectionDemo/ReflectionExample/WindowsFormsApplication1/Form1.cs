using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Assembly asm = Assembly.LoadFile(openFileDialog1.FileName);
            //TaxCalculator o = new TaxCalculator();

            Type t = asm.GetType(asm.GetName().Name + ".TaxCalculator", true, true);
            object obj = Activator.CreateInstance(t);

            
            //o.Basic = 10000
            PropertyInfo p = t.GetProperty("Basic");
            p.SetValue(obj, 10000.00M, null);
            MessageBox.Show(p.GetValue(obj, null).ToString());

            //MessageBox.Show(t.GetNetSal());
            MethodInfo m = t.GetMethod("GetNetSalary");
            decimal NetSal = (decimal)m.Invoke(obj, null);

            MessageBox.Show(NetSal.ToString());
        }
        private void openFileDialog1_FileOk2(object sender, CancelEventArgs e)
        {
            Assembly asm = Assembly.LoadFile(openFileDialog1.FileName);
            //TaxCalculator t = new TaxCalculator();

            Type t = asm.GetType(asm.GetName().Name + ".TaxCalculator", true, true);
            object obj = Activator.CreateInstance(t);
            //object obj = Activator.CreateInstance(t,p1,p2,p3);

            //MethodInfo m = t.GetMethod("GetNetSalary");
            //for overloaded methods

            Type[] arrParams = new Type[2];
            arrParams[0] = ((int)10).GetType();
            arrParams[1] = "ssss".GetType();
            MethodInfo m2 = t.GetMethod("GetNetSalary", arrParams);

            object[] objParams = new object[2];
            objParams[0] = 10;
            objParams[1] = "ssss";
            decimal NetSal = (decimal)m2.Invoke(obj, objParams);



            //decimal NetSal = (decimal)m.Invoke(obj, null);

            MessageBox.Show(NetSal.ToString());
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus449Proj
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MainForm();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
            
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            string fname, lname;
            int id = 1;
            fname = firstTextBox.Text;
            lname = lastTextBox.Text;

            Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter oncall = new Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();
            Bus449_TestDataSetTableAdapters.EmployeeTableAdapter employee = new Bus449_TestDataSetTableAdapters.EmployeeTableAdapter();

           id = int.Parse(employeeTableAdapter.GetDataByName(lname, fname).ToString());

            datesListBox.Items.Add(oncall.GetDataByID(id, id));
            
        }
    }
}

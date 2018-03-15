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

            int id;
            int.TryParse(iDLabel1.Text, out id);
            //fname = firstTextBox.Text;
            //lname = lastTextBox.Text;

            Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter oncall = new Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();
            Bus449_TestDataSetTableAdapters.EmployeeTableAdapter employee = new Bus449_TestDataSetTableAdapters.EmployeeTableAdapter();

            
           //int.TryParse(employeeTableAdapter.GetDataByName(lname, fname).ToString(), out id);
           foreach(DataRow dr in bus449_TestDataSet.Oncall_Calendar.Rows)
            {
                int am, pm;
                int.TryParse(dr["empid_am"].ToString(), out am);
                int.TryParse(dr["empid_pm"].ToString(), out pm);
                if(am == id || pm == id)
                {
                    datesListBox.Items.Add(dr["Date_ID"].ToString());
                }
            }
            
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bus449_TestDataSet.Oncall_Calendar' table. You can move, or remove it, as needed.
            this.oncall_CalendarTableAdapter.Fill(this.bus449_TestDataSet.Oncall_Calendar);
            // TODO: This line of code loads data into the 'bus449_TestDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bus449_TestDataSet.Employee);
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bus449_TestDataSet);

        }
    }
}

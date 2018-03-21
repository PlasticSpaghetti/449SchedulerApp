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
    public partial class Form5 : Form
    {
        public Form5()
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

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bus449_TestDataSet.Oncall_Calendar' table. You can move, or remove it, as needed.
            this.oncall_CalendarTableAdapter.Fill(this.bus449_TestDataSet.Oncall_Calendar);
            // TODO: This line of code loads data into the 'bus449_TestDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bus449_TestDataSet.Employee);

            foreach (DataRow dr in bus449_TestDataSet.Employee.Rows)
            {
                newlnameComboBox.Items.Add(dr["L_Name"].ToString());
            }
         }

        private void oncall_CalendarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oncall_CalendarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bus449_TestDataSet);

        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            int oldid = 0, newid = 0;
            string oldname = l_NameComboBox.Text, newname = newlnameComboBox.Text;
            
            DateTime date = new DateTime();
            date = switchDateTimePicker.Value;

            foreach(DataRow dt in bus449_TestDataSet.Employee.Rows)
            {
                string check = "";
                check = dt["L_Name"].ToString();
                if(oldname == check)
                {
                    oldid = int.Parse(dt["ID"].ToString());
                }
                else if(newname == check)
                {
                    newid = int.Parse(dt["ID"].ToString());
                }
            }
            //creates usable adapter
            Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter oncall = new Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();

            
            foreach(DataRow dr in bus449_TestDataSet.Oncall_Calendar.Rows)
            {
                int am = 0, pm = 0;
                bool holiday = bool.Parse(dr["holiday"].ToString());
                string desc = dr["holiday_desc"].ToString();
                am = int.Parse(dr["empid_am"].ToString());
                pm = int.Parse(dr["empid_pm"].ToString());

                if(am == oldid)
                {
                    oncall.Update(newid, pm, holiday, desc, date, oldid, pm, holiday, desc);
                }
                else if(pm == oldid)
                {
                    oncall.Update(am, newid, holiday, desc, date, oldid, pm, holiday, desc);
                }
            }
        }
    }
}

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

            l_NameComboBox.Items.Clear();
            DateTime date = new DateTime();
            date = switchDateTimePicker.Value;
            string amlname = "", pmlname = "";

            foreach (DataRow dr in bus449_TestDataSet.Oncall_Calendar.Rows)
            {
                DateTime check = new DateTime();
                check = DateTime.Parse(dr["Date_ID"].ToString());

                if (check == date)
                {
                    int am, pm;
                    int.TryParse(dr["empid_am"].ToString(), out am);
                    int.TryParse(dr["empid_pm"].ToString(), out pm);
                   
                    foreach (DataRow dt in bus449_TestDataSet.Employee.Rows)
                    {
                        int check1 = int.Parse(dt["ID"].ToString());
                        if (am == check1)
                        {
                            amlname = dt["L_Name"].ToString();
                            l_NameComboBox.Items.Add(amlname);
                        }
                    }

                    foreach (DataRow dz in bus449_TestDataSet.Employee.Rows)
                    {
                        int check2 = int.Parse(dz["ID"].ToString());
                        if (pm == check2)
                        {
                            pmlname = dz["L_Name"].ToString();
                            l_NameComboBox.Items.Add(pmlname);
                        }
                    }

                }
            }
            l_NameComboBox.Text = amlname;
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
                if(newname == check)
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
                if(pm == oldid)
                {
                    oncall.Update(am, newid, holiday, desc, date, am, oldid, holiday, desc);
                }
            }
            l_NameComboBox.Text = newname;
        }

        private void l_NameComboBox_TextChanged(object sender, EventArgs e)
        {
            newlnameComboBox.Items.Clear();
            string current = l_NameComboBox.Text;
            string tag ="";
            string fname = "";
            foreach (DataRow dr in bus449_TestDataSet.Employee.Rows)
            {
                if (current == dr["L_Name"].ToString())
                {
                    tag = dr["shift"].ToString();
                    fname = dr["F_Name"].ToString();
                    f_NameLabel1.Text = fname;
                }
            }
            foreach(DataRow dt in bus449_TestDataSet.Employee.Rows)
            {
                if(tag == dt["shift"].ToString())
                    newlnameComboBox.Items.Add(dt["L_Name"].ToString());
            }
        }

        private void switchDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            l_NameComboBox.Items.Clear();
            DateTime date = new DateTime();
            date = switchDateTimePicker.Value;
            string amlname = "", pmlname = "";

            foreach (DataRow dr in bus449_TestDataSet.Oncall_Calendar.Rows)
            {
                DateTime check = new DateTime();
                check = DateTime.Parse(dr["Date_ID"].ToString());

                if(check == date)
                {
                    int am, pm;
                    int.TryParse(dr["empid_am"].ToString(), out am);
                    int.TryParse(dr["empid_pm"].ToString(), out pm);
                    
                    foreach (DataRow dt in bus449_TestDataSet.Employee.Rows)
                    {
                        int check1 = int.Parse(dt["ID"].ToString());
                        if (am == check1)
                        {
                            amlname = dt["L_Name"].ToString();
                            l_NameComboBox.Items.Add(amlname);
                        }
                    }

                    foreach (DataRow dz in bus449_TestDataSet.Employee.Rows)
                    {
                        int check2 = int.Parse(dz["ID"].ToString());
                        if (pm == check2)
                        {
                            pmlname = dz["L_Name"].ToString();
                            l_NameComboBox.Items.Add(pmlname);
                        }
                    }
                    
                }
            }
            l_NameComboBox.Text = amlname;

        }

        private void newlnameComboBox_TextChanged(object sender, EventArgs e)
        {
            fnameLabel2.Text = "";
            string current2 = newlnameComboBox.Text;
            string fname2 = "";
            foreach (DataRow dr in bus449_TestDataSet.Employee.Rows)
            {
                if (current2 == dr["L_Name"].ToString())
                {
                    fname2 = dr["F_Name"].ToString();
                    fnameLabel2.Text = fname2;
                }
            }
        }
    }
}

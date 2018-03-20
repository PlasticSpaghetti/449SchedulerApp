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
    public partial class Form4 : Form
    {
        public Form4()
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
            DateTime start = new DateTime();
            DateTime end = new DateTime();
            start = startDateTimePicker.Value;
            end = endDateTimePicker.Value;

            Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter oncall = new Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();
            Bus449_TestDataSetTableAdapters.EmployeeTableAdapter employee = new Bus449_TestDataSetTableAdapters.EmployeeTableAdapter();

            foreach (DataRow dr in bus449_TestDataSet.Oncall_Calendar.Rows)
            {
                DateTime date = new DateTime();
                date = DateTime.Parse(dr["Date_ID"].ToString());
                
                if(date >= start && date <= end)
                {
                    int am, pm;
                    string amlname = "", pmlname = "", amphone = "", pmphone = "", amshift = "", pmshift = "";

                    int.TryParse(dr["empid_am"].ToString(), out am);
                    int.TryParse(dr["empid_pm"].ToString(), out pm);
                    
                    foreach(DataRow dt in bus449_TestDataSet.Employee.Rows)
                    {
                        int check = int.Parse(dt["ID"].ToString());
                        if (am == check)
                        {
                            amlname = dt["L_Name"].ToString();
                            amphone = dt["phone"].ToString();
                            amshift = dt["shift"].ToString();
                        }
                    }
                    
                    foreach (DataRow dz in bus449_TestDataSet.Employee.Rows)
                    {
                        int check2 = int.Parse(dz["ID"].ToString());
                        if (pm == check2)
                        {
                            pmlname = dz["L_Name"].ToString();
                            pmphone = dz["phone"].ToString();
                            pmshift = dz["shift"].ToString();
                        }
                    }
                    string addam = date.ToString("MM/dd/yyyy") + " " + amlname + " " + amphone + " " + amshift;
                    string addpm = date.ToString("MM/dd/yyyy") + " " + pmlname + " " + pmphone + " " + pmshift;

                    dateviewListBox.Items.Add(addam);
                    dateviewListBox.Items.Add(addpm);
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bus449_TestDataSet.Oncall_Calendar' table. You can move, or remove it, as needed.
            this.oncall_CalendarTableAdapter.Fill(this.bus449_TestDataSet.Oncall_Calendar);
            // TODO: This line of code loads data into the 'bus449_TestDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bus449_TestDataSet.Employee);
        }
    }
}

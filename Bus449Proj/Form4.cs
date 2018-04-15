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
            datesListView.Items.Clear();

            DateTime start = new DateTime();
            DateTime end = new DateTime();
            start = startDateTimePicker.Value;
            end = endDateTimePicker.Value;

            Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter oncall = new Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();
            Bus449_TestDataSetTableAdapters.EmployeeTableAdapter employee = new Bus449_TestDataSetTableAdapters.EmployeeTableAdapter();
            DataView calendar = new DataView(bus449_TestDataSet.Oncall_Calendar);
            calendar.Sort = "Date_ID ASC";
            foreach (DataRowView dr in calendar)
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
                    //Create a listview to show all products and purchase amounts
                    string[] fieldsArrayAM = new string[4];
                    fieldsArrayAM[0] = date.ToString("MM/dd/yyyy");
                    fieldsArrayAM[1] = amlname;
                    fieldsArrayAM[2] = amphone;
                    fieldsArrayAM[3] = amshift;
                    ListViewItem showsLVI = new ListViewItem(fieldsArrayAM );
                    datesListView.Items.Add(showsLVI);

                    string[] fieldsArrayPM = new string[4];
                    fieldsArrayPM[0] = date.ToString("MM/dd/yyyy");
                    fieldsArrayPM[1] = pmlname;
                    fieldsArrayPM[2] = pmphone;
                    fieldsArrayPM[3] = pmshift;
                    ListViewItem showsLVI2 = new ListViewItem(fieldsArrayPM);
                    datesListView.Items.Add(showsLVI2);
                    //string addam = date.ToString("MM/dd/yyyy") + " " + amlname + " " + amphone + " " + amshift;
                    //string addpm = date.ToString("MM/dd/yyyy") + " " + pmlname + " " + pmphone + " " + pmshift;

                    
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bus449_TestDataSet.Oncall_Calendar' table. You can move, or remove it, as needed.
            this.oncall_CalendarTableAdapter.Fill(this.bus449_TestDataSet.Oncall_Calendar);
            // TODO: This line of code loads data into the 'bus449_TestDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bus449_TestDataSet.Employee);

            DataView calendar = new DataView(bus449_TestDataSet.Oncall_Calendar);
            calendar.Sort = "Date_ID ASC";
            int count = 0;
            foreach(DataRowView dr in calendar)
            {
                if(count == 0)
                {
                    startDateTimePicker.Value = DateTime.Parse(dr["Date_ID"].ToString());
                    endDateTimePicker.Value = DateTime.Parse(dr["Date_ID"].ToString());
                }
                count++;
            }


        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(endDateTimePicker.Value < startDateTimePicker.Value)
                endDateTimePicker.Value = startDateTimePicker.Value;
        }
    }
}

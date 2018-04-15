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
    public partial class Form2 : Form
    {
        //counter variables for am and pm employees
        private int amemps, pmemps, a,p;
        private int[] holia, holip, amid, pmid;

        public Form2()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            enddateTimePicker.MinDate = startdateTimePicker.Value;
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MainForm();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool holiday = true;
            string holiname = "";

            DateTime day = new DateTime();
            day = holidayTimePicker.Value;

            holiname = holiday_descTextBox.Text;

           
            
            Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter oncall = new Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();
            int x =0, y = 0;
            //populates the array for holiday am and pm employees
            foreach (DataRow dr in bus449_TestDataSet.Employee.Rows)
            {
                if (dr["shift"].ToString() == "A")
                {
                    holia[x] = int.Parse(dr["ID"].ToString());
                    x++;
                }
                else
                {
                    holip[y] = int.Parse(dr["ID"].ToString());
                    y++;
                }

            }
            int count = 0;
            count = (int)oncall.ScalarCheck(day.Date);
            if (count <= 0)
            {
                //inserts the holiday into the calendar with employees
                oncall.Insert(day.Date, holia[a], holip[p], holiday, holiname);
                //adds the holiday date to the listbox
                holidaysListBox.Items.Add(day.ToString("MM/dd/yyyy") + " " + holiname);


                a++; p++;
            }
            else
            {
                MessageBox.Show("That date already exists.");
            }
                if (a >= holia.Length)
                    a = 0;
                if (p >= holip.Length)
                    p = 0;
            
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Have you entered all of the desired holidays", "Holiday Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //creates and sets start and end date variables
                DateTime startdate = new DateTime();
                DateTime enddate = new DateTime();
                startdate = startdateTimePicker.Value;
                enddate = enddateTimePicker.Value;

                //creates usable adapter
                Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter oncall = new Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();



                //creates and populates arrays for employees IDs
                int x = 0, y = 0;
                foreach (DataRow dr in bus449_TestDataSet.Employee.Rows)
                {
                    if (dr["shift"].ToString() == "A")
                    {
                        amid[x] = int.Parse(dr["ID"].ToString());
                        x++;
                    }
                    else
                    {
                        pmid[y] = int.Parse(dr["ID"].ToString());
                        y++;
                    }

                }


                int loopa = 0, loopp = 0; bool holiday = false;
                string holiname = "";
                //loops from startdate to enddate
                for (var day = startdate.Date; day.Date <= enddate.Date; day = day.AddDays(1))
                {
                    int count = 0;
                    count = (int)oncall.ScalarCheck(day.Date);
                    if (count <= 0)
                    {
                        //inserts the day into the calendar with an am and pm oncall employee
                        oncall.Insert(day.Date, amid[loopa], pmid[loopp], holiday, holiname);

                        //rotates to next employee
                        loopa++; loopp++;

                    }

                    //resets the array to prevent errors
                    if (loopa >= amid.Length)
                        loopa = 0;
                    if (loopp >= pmid.Length)
                        loopp = 0;


                }
                this.tableAdapterManager.UpdateAll(this.bus449_TestDataSet);
            }
        }

        private void oncall_CalendarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oncall_CalendarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bus449_TestDataSet);

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            holidaysListBox.Items.Clear();
            //clears the calendar
            foreach (DataRow dr in bus449_TestDataSet.Oncall_Calendar.Rows)
            {
                dr.Delete();
            }
                this.tableAdapterManager.UpdateAll(this.bus449_TestDataSet);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bus449_TestDataSet.Oncall_Calendar' table. You can move, or remove it, as needed.
            this.oncall_CalendarTableAdapter.Fill(this.bus449_TestDataSet.Oncall_Calendar);
            // TODO: This line of code loads data into the 'bus449_TestDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bus449_TestDataSet.Employee);

            //counts the number of am and pm employees
            amemps = (int)this.employeeTableAdapter.AMCount();
            pmemps = (int)this.employeeTableAdapter.PMCount();

            //populates holiday loop arrays
            holia = new int[amemps];
            holip = new int[pmemps];

            //populates regular loop arrays
            amid = new int[amemps];
            pmid = new int[pmemps];

            foreach(DataRow dr in bus449_TestDataSet.Oncall_Calendar.Rows)
            {
                string holiday;
                DateTime holidate;
                if (bool.Parse(dr["holiday"].ToString()))
                {
                    holiday = dr["holiday_desc"].ToString();
                    holidate = DateTime.Parse(dr["Date_ID"].ToString());
                    holidaysListBox.Items.Add(holiday + " " + holidate.ToString("MM/dd/yyyy"));
                }
            }

          
        }
    }
}

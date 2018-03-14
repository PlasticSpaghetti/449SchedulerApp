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
        private int amemps, pmemps;

        public Form2()
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

        private void addButton_Click(object sender, EventArgs e)
        {
            //adds the holiday date to the listbox
            holidaysListBox.Items.Add(holidayTimePicker.Value + " " + holiday_descTextBox.Text);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //creates and sets start and end date variables
            DateTime startdate = new DateTime();
            DateTime enddate = new DateTime();
            startdate = startdateTimePicker.Value;
            enddate = enddateTimePicker.Value;

            //counts the number of am and pm employees
            amemps = (int) this.employeeTableAdapter.AMCount();
            pmemps = (int) this.employeeTableAdapter.PMCount();

            //creates and populates arrays for employees IDs
            int[] amid = new int[amemps];
            int[] pmid = new int[pmemps];
            int x = 0, y = 0;
            foreach(DataRow dr in bus449_TestDataSet.Employee.Rows)
            {
                if(dr["shift"].ToString() == "A")
                {
                    int.TryParse(dr["ID"].ToString(), out amid[x]);
                    x++;
                }
                else
                {
                    int.TryParse(dr["ID"].ToString(), out pmid[y]);
                    y++;
                }

            }

            int loopa=0, loopp=0; bool holiday = false;
            string holiname = "";
            //loops from startdate to enddate
            for (var day = startdate.Date; day.Date <= enddate.Date; day = day.AddDays(1))
            {

                //checks if the day is a holiday or not
                if (holidaysListBox.Items.Contains(day.Date))
                {
                    holiday = true;
                }
                else
                    holiday = false;
                //creates usable adapter
                Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter oncall = new Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();
                //inserts the day into the calendar with an am and pm oncall employee
                oncall.Insert(day.Date, amid[loopa], pmid[loopp], holiday, holiname);

                //rotates to next employee
                loopa++; loopp++;

                //resets the array to prevent errors
                if (loopa >= amid.Length)
                    loopa = 0;
                if (loopp >= pmid.Length)
                    loopp = 0;

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
            //clears the calendar
            this.bus449_TestDataSet.Oncall_Calendar.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bus449_TestDataSet.Oncall_Calendar' table. You can move, or remove it, as needed.
            this.oncall_CalendarTableAdapter.Fill(this.bus449_TestDataSet.Oncall_Calendar);

        }
    }
}

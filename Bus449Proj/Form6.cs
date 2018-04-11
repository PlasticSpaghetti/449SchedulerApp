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
    
    public partial class Form6 : Form
    {
        bool add = false, delete = false, shift = false;
        int delid = 0;
        string delshift = "";

        public Form6()
        {
            InitializeComponent();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MainForm();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            
            
            try
            {
                this.Validate();
                this.employeeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bus449_TestDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }




        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bus449_TestDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bus449_TestDataSet.Employee);
            // TODO: This line of code loads data into the 'bus449_TestDataSet.Oncall_Calendar' table. You can move, or remove it, as needed.
            this.oncall_CalendarTableAdapter.Fill(this.bus449_TestDataSet.Oncall_Calendar);

        }

        private void shiftComboBox_TextChanged(object sender, EventArgs e)
        {
            /*foreach (DataRow dr in bus449_TestDataSet.Employee.Rows)
            {
                string check = dr["shift"].ToString();
                if (int.Parse(iDComboBox.ToString()) == int.Parse(dr["ID"].ToString()) && shiftComboBox.Text != check)
                {
                    shift = true;

                }
                else
                    shift = false;
            }*/
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            delete = true;
            delid = int.Parse(iDTextBox.Text);
            delshift = shiftComboBox.Text;

            int a=0, p=0;
            int[] empam, emppm;

            empam = new int[(int)this.employeeTableAdapter.AMCount()];
            emppm = new int[(int)this.employeeTableAdapter.PMCount()];

            foreach(DataRow dt in bus449_TestDataSet.Employee.Rows)
            {
                if(dt["shift"].ToString() == "A")
                {
                    empam[a] = int.Parse(dt["ID"].ToString());
                    a++;
                }
                else
                {
                    emppm[p] = int.Parse(dt["ID"].ToString());
                    p++;
                }

            }

            /* DateTime update = new DateTime();
             var form2 = new Form8();
             form2.Show();

             //gets the date from the popup form
             update = form2.getDate();*/

            //creates usable adapter
            Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter oncall = new Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();

            int count = 0;
            foreach (DataRow dr in bus449_TestDataSet.Oncall_Calendar.Rows)
            {
                if (delid == empam[count] || delid == emppm[count])
                    count++;

                if (delid == int.Parse(dr["empid_am"].ToString()))
                {
                    oncall.Update(empam[count], int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString(),
                        DateTime.Parse(dr["Date_ID"].ToString()), delid, int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString());
                    count++;
                }
                if (delid == int.Parse(dr["empid_pm"].ToString()))
                {
                    oncall.Update(int.Parse(dr["empid_am"].ToString()), emppm[count], bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString(),
                        DateTime.Parse(dr["Date_ID"].ToString()), int.Parse(dr["empid_am"].ToString()), delid, bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString());
                    count++;
                }
                if (count >= empam.Length || count >= emppm.Length)
                {
                    count = 0;
                }

            }
            foreach (DataRow dt in bus449_TestDataSet.Employee.Rows)
            {
                if (delid == int.Parse(dt["ID"].ToString()))
                    dt.Delete();
            }
            //saves any changes made to an employee

            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bus449_TestDataSet);
            

        }

        private void addsaveButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bus449_TestDataSet);

            int a = 0, p = 0, la, lp;
            int[] empam, emppm;

            string checker = "";
            int checkers = shiftComboBox.SelectedIndex;

            la = (int)this.employeeTableAdapter.AMCount();
            lp = (int)this.employeeTableAdapter.PMCount();

          /*  if (shiftComboBox.Text == "A" || checkers == 0)
            {
                empam = new int[la+1];
                checker = "A";
                //empam[empam.Length - 1] = int.Parse(iDTextBox.Text);
            }
            else
                empam = new int[la];

            if (shiftComboBox.Text == "P" || checkers == 1)
            {
                emppm = new int[lp+1];
                checker = "P";
                //emppm[emppm.Length - 1] = int.Parse(iDTextBox.Text)
            }
            else
                emppm = new int[lp];
            */
            //creates usable adapter
            Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter oncall = new Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();

            int holicountx = 0, holicounty = 0, x = 0, y =0;

            empam = new int[la];
            emppm = new int[lp];

            foreach (DataRow dt in bus449_TestDataSet.Employee.Rows)
            {
                if (dt["shift"].ToString() == "A")
                {
                    empam[a] = int.Parse(dt["ID"].ToString());
                    a++;
                }
                else
                {
                    emppm[p] = int.Parse(dt["ID"].ToString());
                    p++;
                }

            }
            checker = shiftComboBox.Text;
            foreach (DataRow dr in bus449_TestDataSet.Oncall_Calendar.Rows)
            {
                
                //weights holidays
                if (bool.Parse(dr["holiday"].ToString()))
                {
                    oncall.Update(empam[holicountx], int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString(),
                        DateTime.Parse(dr["Date_ID"].ToString()), int.Parse(dr["empid_am"].ToString()), int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString());
                    holicountx++;
                
                
                    oncall.Update(int.Parse(dr["empid_am"].ToString()), emppm[holicounty], bool.Parse(dr["holiday"].ToString()), dr["holday_desc"].ToString(),
                        DateTime.Parse(dr["Date_ID"].ToString()), int.Parse(dr["empid_am"].ToString()), int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString());
                    holicounty++;
                }
                if (holicountx >= empam.Length)
                {
                    holicountx = 0;
                }
                if(holicounty >= emppm.Length)
                {
                    holicounty = 0;
                }
            //does the other days
            if (!bool.Parse(dr["holiday"].ToString()))
            {
                oncall.Update(empam[x], int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString(),
                        DateTime.Parse(dr["Date_ID"].ToString()), int.Parse(dr["empid_am"].ToString()), int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString());
                x++;

                oncall.Update(int.Parse(dr["empid_am"].ToString()), emppm[y], bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString(),
                    DateTime.Parse(dr["Date_ID"].ToString()), int.Parse(dr["empid_am"].ToString()), int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString());
                y++;
            }
                if (x >= empam.Length)
                {
                    x = 0;
                }
                if(y >= emppm.Length)
                {
                    y = 0;
                }

            }

            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bus449_TestDataSet);
        }

        private void shiftButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bus449_TestDataSet);

            int a = 0, p = 0, la, lp;
            int[] empam, emppm;

            string checker = "", old = "";
            int checkers = shiftComboBox.SelectedIndex;

            la = (int)this.employeeTableAdapter.AMCount();
            lp = (int)this.employeeTableAdapter.PMCount();

            /*if (shiftComboBox.Text == "A" || checkers == 0)
            {
                la = la + 1;
                checker = "A";
                old = "P";
            }
            if (shiftComboBox.Text == "P" || checkers == 1)
            {
                lp = lp + 1;
                checker = "P";
                old = "A";
            }*/


            empam = new int[la];
            emppm = new int[lp];
            //creates usable adapter
            Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter oncall = new Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();

            int holicountx = 0,holicounty =0, x = 0, y = 0;


            foreach (DataRow dt in bus449_TestDataSet.Employee.Rows)
            {
                if (dt["shift"].ToString() == "A")
                {
                    empam[a] = int.Parse(dt["ID"].ToString());
                    a++;
                }
                else
                {
                    emppm[p] = int.Parse(dt["ID"].ToString());
                    p++;
                }

            }
            checker = shiftComboBox.Text;
            foreach (DataRow dr in bus449_TestDataSet.Oncall_Calendar.Rows)
            {

                //weights holidays
                if (bool.Parse(dr["holiday"].ToString()))
                {
                    oncall.Update(empam[holicountx], int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString(),
                        DateTime.Parse(dr["Date_ID"].ToString()), int.Parse(dr["empid_am"].ToString()), int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString());
                    holicountx++;


                    oncall.Update(int.Parse(dr["empid_am"].ToString()), emppm[holicounty], bool.Parse(dr["holiday"].ToString()), dr["holday_desc"].ToString(),
                        DateTime.Parse(dr["Date_ID"].ToString()), int.Parse(dr["empid_am"].ToString()), int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString());
                    holicounty++;
                }
                if (holicountx >= empam.Length)
                {
                    holicountx = 0;
                }
                if(holicounty >= emppm.Length)
                {
                    holicounty = 0;
                }
                //does the other days

                if (!bool.Parse(dr["holiday"].ToString()))
                {
                    oncall.Update(empam[x], int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString(),
                        DateTime.Parse(dr["Date_ID"].ToString()), int.Parse(dr["empid_am"].ToString()), int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString());
                    x++;

                    oncall.Update(int.Parse(dr["empid_am"].ToString()), emppm[y], bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString(),
                        DateTime.Parse(dr["Date_ID"].ToString()), int.Parse(dr["empid_am"].ToString()), int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["holiday_desc"].ToString());
                    y++;
                }
                if (x >= empam.Length)
                {
                    x = 0;
                }
                if(y >= emppm.Length)
                {
                    y = 0;
                }

            }

            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bus449_TestDataSet);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            add = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
        
    }
}

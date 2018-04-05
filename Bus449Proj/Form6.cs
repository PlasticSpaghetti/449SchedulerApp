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

            

            foreach (DataRow dr in bus449_TestDataSet.Employee.Rows)
            {
                if(shiftComboBox.Text != dr["shift"].ToString())
                {
                    shift = true;
                }
            }
            if (delete == true || add == true || shift == true)
            {
                int[] empam, emppm;
                empam = new int[(int)this.employeeTableAdapter.AMCount()];
                emppm = new int[(int)this.employeeTableAdapter.AMCount()];

                DateTime update = new DateTime();
                var form2 = new Form8();
                form2.Show();
                
                //gets the date from the popup form
                update = form2.getDate();

                //creates usable adapter
                Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter oncall = new Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();

                //crazy chunk of code to auto-update upon deletion of an employee
                    if (delete == true)
                    {
                        int count = 0;
                        foreach (DataRow dr in bus449_TestDataSet.Oncall_Calendar.Rows)
                        {
                            if (update.Date <= DateTime.Parse(dr["Date_ID"].ToString()).Date)
                            {
                                if (delid == int.Parse(dr["empid_am"].ToString()))
                                {
                                    oncall.Update(empam[count], int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString(),
                                        DateTime.Parse(dr["Date_ID"].ToString()), delid, int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString());
                                    count++;
                                }
                                if (delid == int.Parse(dr["empid_pm"].ToString()))
                                {
                                    oncall.Update(int.Parse(dr["empid_am"].ToString()), emppm[count], bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString(),
                                        DateTime.Parse(dr["Date_ID"].ToString()), int.Parse(dr["empid_am"].ToString()), delid, bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString());
                                    count++;
                                }
                                if (count >= empam.Length || count >= emppm.Length)
                                {
                                    count = 0;
                                }
                            }
                        }
                    }
                if(add == true)
                {
                    int holicount = 0, x = 0;
                    string checker = shiftComboBox.ToString();
                    foreach (DataRow dr in bus449_TestDataSet.Oncall_Calendar.Rows)
                    {
                        if (update.Date <= DateTime.Parse(dr["Date_ID"].ToString()).Date)
                        {
                            //weights holidays
                            if (checker == "A" && bool.Parse(dr["holiday"].ToString()))
                            {
                                oncall.Update(empam[holicount], int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString(),
                                    DateTime.Parse(dr["Date_ID"].ToString()), delid, int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString());
                                holicount++;
                            }
                            if (checker == "P" && bool.Parse(dr["holiday"].ToString()))
                            {
                                oncall.Update(int.Parse(dr["empid_am"].ToString()), emppm[holicount], bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString(),
                                    DateTime.Parse(dr["Date_ID"].ToString()), int.Parse(dr["empid_am"].ToString()), delid, bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString());
                                holicount++;
                            }
                            if (holicount >= empam.Length || holicount >= emppm.Length)
                            {
                                holicount = 0;
                            }
                            //does the other days
                            if (checker == "A" && !bool.Parse(dr["holiday"].ToString()))
                            {
                                oncall.Update(empam[x], int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString(),
                                    DateTime.Parse(dr["Date_ID"].ToString()), delid, int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString());
                                x++;
                            }
                            if (checker == "P" && !bool.Parse(dr["holiday"].ToString()))
                            {
                                oncall.Update(int.Parse(dr["empid_am"].ToString()), emppm[x], bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString(),
                                    DateTime.Parse(dr["Date_ID"].ToString()), int.Parse(dr["empid_am"].ToString()), delid, bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString());
                                x++;
                            }
                            if (x >= empam.Length || x >= emppm.Length)
                            {
                                x = 0;
                            }
                        }
                    }

                }
                if(shift == true)
                {
                    int holicounta = 0, holicountp = 0, x = 0, y =0;
                    string checker = shiftComboBox.ToString();
                    foreach (DataRow dr in bus449_TestDataSet.Oncall_Calendar.Rows)
                    {
                        if (update.Date <= DateTime.Parse(dr["Date_ID"].ToString()).Date)
                        {
                            if (bool.Parse(dr["holiday"].ToString()))
                            {
                                oncall.Update(empam[holicounta], int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString(),
                                    DateTime.Parse(dr["Date_ID"].ToString()), delid, int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString());
                                holicounta++;
                                oncall.Update(empam[holicountp], int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString(),
                                    DateTime.Parse(dr["Date_ID"].ToString()), delid, int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString());
                                holicountp++;
                            }
                            else
                            {
                                oncall.Update(empam[x], int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString(),
                                    DateTime.Parse(dr["Date_ID"].ToString()), delid, int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString());
                                x++;
                                oncall.Update(empam[y], int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString(),
                                    DateTime.Parse(dr["Date_ID"].ToString()), delid, int.Parse(dr["empid_pm"].ToString()), bool.Parse(dr["holiday"].ToString()), dr["desc"].ToString());
                                y++;
                            }
                            
                            if (x >= empam.Length)
                            {
                                x = 0;
                            }
                            if (y >= emppm.Length)
                            {
                                y = 0;
                            }

                            if (holicounta >= empam.Length)
                            {
                                holicounta = 0;
                            }
                            if (holicountp >= emppm.Length)
                            {
                                holicountp = 0;
                            }
                        }
                    }
                }                   
            }

            
                //saves any changes made to an employee
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            add = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            delete = true;
            delid = int.Parse(iDComboBox.Text);
            delshift = shiftComboBox.Text;
        }

    }
}

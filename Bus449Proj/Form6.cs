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
            

            foreach(DataRow dr in bus449_TestDataSet.Employee.Rows)
            {
                if(shiftComboBox.Text != dr["shift"].ToString())
                {
                    shift = true;
                }
            }
            if (delete == true || add == true || shift == true)
            {
                DateTime update = new DateTime();
                var form2 = new Form8();
                form2.Show();

                //gets the date from the popup form
                update = form2.getDate();
                
                if(delete == true)
                {

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
        }

    }
}

﻿using System;
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
    public partial class Form8 : Form
    {
        public bool good = false;
        public DateTime change = new DateTime();

        public DateTime getDate()
        {
            return change.Date;
        }
        public Boolean getOK()
        {
            return good;
        }

        public Form8()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            good = false;
        }

        private void oncall_CalendarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oncall_CalendarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bus449_TestDataSet);

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            change = date_IDDateTimePicker.Value;
            good = true;
        }
        
        
    }
   
}

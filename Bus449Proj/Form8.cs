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
    public partial class Form8 : Form
    {




        public Form8()
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
    }
   
}

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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form2();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();

        }

        private void dateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form4();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form3();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form5();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form6();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form7();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }
    }
}

namespace Bus449Proj
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.createButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dateButton = new System.Windows.Forms.Button();
            this.switchButton = new System.Windows.Forms.Button();
            this.manageButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(6, 19);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(117, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create Calendar";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(6, 19);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(115, 23);
            this.userButton.TabIndex = 1;
            this.userButton.Text = "View by Employee";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(319, 215);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dateButton
            // 
            this.dateButton.Location = new System.Drawing.Point(6, 48);
            this.dateButton.Name = "dateButton";
            this.dateButton.Size = new System.Drawing.Size(115, 23);
            this.dateButton.TabIndex = 3;
            this.dateButton.Text = "View by Date";
            this.dateButton.UseVisualStyleBackColor = true;
            this.dateButton.Click += new System.EventHandler(this.dateButton_Click);
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(6, 77);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(117, 23);
            this.switchButton.TabIndex = 4;
            this.switchButton.Text = "Switch";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // manageButton
            // 
            this.manageButton.Location = new System.Drawing.Point(6, 48);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(117, 23);
            this.manageButton.TabIndex = 5;
            this.manageButton.Text = "Manage Employees";
            this.manageButton.UseVisualStyleBackColor = true;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userButton);
            this.groupBox1.Controls.Add(this.dateButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 107);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.createButton);
            this.groupBox2.Controls.Add(this.manageButton);
            this.groupBox2.Controls.Add(this.switchButton);
            this.groupBox2.Location = new System.Drawing.Point(222, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 107);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Bus449Proj.Properties.Resources.cn_logo_full_g;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 65);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 249);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button dateButton;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.Button manageButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


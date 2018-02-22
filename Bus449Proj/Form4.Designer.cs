namespace Bus449Proj
{
    partial class Form4
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
            this.mainButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endyearTextBox = new System.Windows.Forms.TextBox();
            this.enddayTextBox = new System.Windows.Forms.TextBox();
            this.endmonthTextBox = new System.Windows.Forms.TextBox();
            this.startdayTextBox = new System.Windows.Forms.TextBox();
            this.startyearTextBox = new System.Windows.Forms.TextBox();
            this.startmonthTextBox = new System.Windows.Forms.TextBox();
            this.dateviewListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(194, 212);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(75, 23);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "Main Menu";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(194, 258);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Date:";
            // 
            // endyearTextBox
            // 
            this.endyearTextBox.Location = new System.Drawing.Point(172, 67);
            this.endyearTextBox.Name = "endyearTextBox";
            this.endyearTextBox.Size = new System.Drawing.Size(38, 20);
            this.endyearTextBox.TabIndex = 15;
            // 
            // enddayTextBox
            // 
            this.enddayTextBox.Location = new System.Drawing.Point(128, 67);
            this.enddayTextBox.Name = "enddayTextBox";
            this.enddayTextBox.Size = new System.Drawing.Size(38, 20);
            this.enddayTextBox.TabIndex = 14;
            // 
            // endmonthTextBox
            // 
            this.endmonthTextBox.Location = new System.Drawing.Point(84, 67);
            this.endmonthTextBox.Name = "endmonthTextBox";
            this.endmonthTextBox.Size = new System.Drawing.Size(38, 20);
            this.endmonthTextBox.TabIndex = 13;
            // 
            // startdayTextBox
            // 
            this.startdayTextBox.Location = new System.Drawing.Point(128, 13);
            this.startdayTextBox.Name = "startdayTextBox";
            this.startdayTextBox.Size = new System.Drawing.Size(38, 20);
            this.startdayTextBox.TabIndex = 12;
            // 
            // startyearTextBox
            // 
            this.startyearTextBox.Location = new System.Drawing.Point(172, 13);
            this.startyearTextBox.Name = "startyearTextBox";
            this.startyearTextBox.Size = new System.Drawing.Size(38, 20);
            this.startyearTextBox.TabIndex = 11;
            // 
            // startmonthTextBox
            // 
            this.startmonthTextBox.Location = new System.Drawing.Point(84, 13);
            this.startmonthTextBox.Name = "startmonthTextBox";
            this.startmonthTextBox.Size = new System.Drawing.Size(38, 20);
            this.startmonthTextBox.TabIndex = 10;
            // 
            // dateviewListBox
            // 
            this.dateviewListBox.FormattingEnabled = true;
            this.dateviewListBox.Location = new System.Drawing.Point(16, 115);
            this.dateviewListBox.Name = "dateviewListBox";
            this.dateviewListBox.Size = new System.Drawing.Size(150, 160);
            this.dateviewListBox.TabIndex = 16;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 301);
            this.Controls.Add(this.dateviewListBox);
            this.Controls.Add(this.endyearTextBox);
            this.Controls.Add(this.enddayTextBox);
            this.Controls.Add(this.endmonthTextBox);
            this.Controls.Add(this.startdayTextBox);
            this.Controls.Add(this.startyearTextBox);
            this.Controls.Add(this.startmonthTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mainButton);
            this.Name = "Form4";
            this.Text = "Date View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox endyearTextBox;
        private System.Windows.Forms.TextBox enddayTextBox;
        private System.Windows.Forms.TextBox endmonthTextBox;
        private System.Windows.Forms.TextBox startdayTextBox;
        private System.Windows.Forms.TextBox startyearTextBox;
        private System.Windows.Forms.TextBox startmonthTextBox;
        private System.Windows.Forms.ListBox dateviewListBox;
    }
}
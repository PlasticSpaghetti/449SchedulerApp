namespace Bus449Proj
{
    partial class Form5
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
            this.switchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currentfirstTextBox = new System.Windows.Forms.TextBox();
            this.currentlastTextBox = new System.Windows.Forms.TextBox();
            this.newfirstTextBox = new System.Windows.Forms.TextBox();
            this.newlastTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.swtichmonthTextBox = new System.Windows.Forms.TextBox();
            this.switchyearTextBox = new System.Windows.Forms.TextBox();
            this.switchdayTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(97, 214);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(75, 23);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "Main Menu";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(186, 214);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(16, 214);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(75, 23);
            this.switchButton.TabIndex = 2;
            this.switchButton.Text = "Switch";
            this.switchButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "New First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "New Last Name:";
            // 
            // currentfirstTextBox
            // 
            this.currentfirstTextBox.Location = new System.Drawing.Point(141, 15);
            this.currentfirstTextBox.Name = "currentfirstTextBox";
            this.currentfirstTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentfirstTextBox.TabIndex = 7;
            // 
            // currentlastTextBox
            // 
            this.currentlastTextBox.Location = new System.Drawing.Point(141, 55);
            this.currentlastTextBox.Name = "currentlastTextBox";
            this.currentlastTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentlastTextBox.TabIndex = 8;
            // 
            // newfirstTextBox
            // 
            this.newfirstTextBox.Location = new System.Drawing.Point(398, 15);
            this.newfirstTextBox.Name = "newfirstTextBox";
            this.newfirstTextBox.Size = new System.Drawing.Size(100, 20);
            this.newfirstTextBox.TabIndex = 9;
            // 
            // newlastTextBox
            // 
            this.newlastTextBox.Location = new System.Drawing.Point(398, 50);
            this.newlastTextBox.Name = "newlastTextBox";
            this.newlastTextBox.Size = new System.Drawing.Size(100, 20);
            this.newlastTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Switch Date:";
            // 
            // swtichmonthTextBox
            // 
            this.swtichmonthTextBox.Location = new System.Drawing.Point(136, 114);
            this.swtichmonthTextBox.Name = "swtichmonthTextBox";
            this.swtichmonthTextBox.Size = new System.Drawing.Size(36, 20);
            this.swtichmonthTextBox.TabIndex = 12;
            // 
            // switchyearTextBox
            // 
            this.switchyearTextBox.Location = new System.Drawing.Point(220, 114);
            this.switchyearTextBox.Name = "switchyearTextBox";
            this.switchyearTextBox.Size = new System.Drawing.Size(47, 20);
            this.switchyearTextBox.TabIndex = 13;
            // 
            // switchdayTextBox
            // 
            this.switchdayTextBox.Location = new System.Drawing.Point(178, 114);
            this.switchdayTextBox.Name = "switchdayTextBox";
            this.switchdayTextBox.Size = new System.Drawing.Size(36, 20);
            this.switchdayTextBox.TabIndex = 14;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 278);
            this.Controls.Add(this.switchdayTextBox);
            this.Controls.Add(this.switchyearTextBox);
            this.Controls.Add(this.swtichmonthTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newlastTextBox);
            this.Controls.Add(this.newfirstTextBox);
            this.Controls.Add(this.currentlastTextBox);
            this.Controls.Add(this.currentfirstTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mainButton);
            this.Name = "Form5";
            this.Text = "Switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currentfirstTextBox;
        private System.Windows.Forms.TextBox currentlastTextBox;
        private System.Windows.Forms.TextBox newfirstTextBox;
        private System.Windows.Forms.TextBox newlastTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox swtichmonthTextBox;
        private System.Windows.Forms.TextBox switchyearTextBox;
        private System.Windows.Forms.TextBox switchdayTextBox;
    }
}
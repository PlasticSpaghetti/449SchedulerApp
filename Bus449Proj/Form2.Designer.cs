namespace Bus449Proj
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.startmonthTextBox = new System.Windows.Forms.TextBox();
            this.startyearTextBox = new System.Windows.Forms.TextBox();
            this.startdayTextBox = new System.Windows.Forms.TextBox();
            this.endmonthTextBox = new System.Windows.Forms.TextBox();
            this.enddayTextBox = new System.Windows.Forms.TextBox();
            this.endyearTextBox = new System.Windows.Forms.TextBox();
            this.mainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Date:";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(16, 201);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(100, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create Schedule";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(239, 201);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // startmonthTextBox
            // 
            this.startmonthTextBox.Location = new System.Drawing.Point(78, 50);
            this.startmonthTextBox.Name = "startmonthTextBox";
            this.startmonthTextBox.Size = new System.Drawing.Size(38, 20);
            this.startmonthTextBox.TabIndex = 4;
            // 
            // startyearTextBox
            // 
            this.startyearTextBox.Location = new System.Drawing.Point(166, 50);
            this.startyearTextBox.Name = "startyearTextBox";
            this.startyearTextBox.Size = new System.Drawing.Size(38, 20);
            this.startyearTextBox.TabIndex = 5;
            // 
            // startdayTextBox
            // 
            this.startdayTextBox.Location = new System.Drawing.Point(122, 50);
            this.startdayTextBox.Name = "startdayTextBox";
            this.startdayTextBox.Size = new System.Drawing.Size(38, 20);
            this.startdayTextBox.TabIndex = 6;
            // 
            // endmonthTextBox
            // 
            this.endmonthTextBox.Location = new System.Drawing.Point(78, 104);
            this.endmonthTextBox.Name = "endmonthTextBox";
            this.endmonthTextBox.Size = new System.Drawing.Size(38, 20);
            this.endmonthTextBox.TabIndex = 7;
            // 
            // enddayTextBox
            // 
            this.enddayTextBox.Location = new System.Drawing.Point(122, 104);
            this.enddayTextBox.Name = "enddayTextBox";
            this.enddayTextBox.Size = new System.Drawing.Size(38, 20);
            this.enddayTextBox.TabIndex = 8;
            // 
            // endyearTextBox
            // 
            this.endyearTextBox.Location = new System.Drawing.Point(166, 104);
            this.endyearTextBox.Name = "endyearTextBox";
            this.endyearTextBox.Size = new System.Drawing.Size(38, 20);
            this.endyearTextBox.TabIndex = 9;
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(122, 201);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(111, 23);
            this.mainButton.TabIndex = 10;
            this.mainButton.Text = "Main Menu";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 305);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.endyearTextBox);
            this.Controls.Add(this.enddayTextBox);
            this.Controls.Add(this.endmonthTextBox);
            this.Controls.Add(this.startdayTextBox);
            this.Controls.Add(this.startyearTextBox);
            this.Controls.Add(this.startmonthTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Create Schedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox startmonthTextBox;
        private System.Windows.Forms.TextBox startyearTextBox;
        private System.Windows.Forms.TextBox startdayTextBox;
        private System.Windows.Forms.TextBox endmonthTextBox;
        private System.Windows.Forms.TextBox enddayTextBox;
        private System.Windows.Forms.TextBox endyearTextBox;
        private System.Windows.Forms.Button mainButton;
    }
}
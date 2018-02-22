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
            this.createButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dateButton = new System.Windows.Forms.Button();
            this.switchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(158, 48);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(105, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create Calendar";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(158, 103);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(105, 23);
            this.userButton.TabIndex = 1;
            this.userButton.Text = "View by Employee";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(158, 241);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dateButton
            // 
            this.dateButton.Location = new System.Drawing.Point(158, 153);
            this.dateButton.Name = "dateButton";
            this.dateButton.Size = new System.Drawing.Size(105, 23);
            this.dateButton.TabIndex = 3;
            this.dateButton.Text = "View by Date";
            this.dateButton.UseVisualStyleBackColor = true;
            this.dateButton.Click += new System.EventHandler(this.dateButton_Click);
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(158, 200);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(105, 23);
            this.switchButton.TabIndex = 4;
            this.switchButton.Text = "Switch";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 314);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.dateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.createButton);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button dateButton;
        private System.Windows.Forms.Button switchButton;
    }
}


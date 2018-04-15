namespace Bus449Proj
{
    partial class Form8
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.mainButton = new System.Windows.Forms.Button();
            this.bus449_TestDataSet = new Bus449Proj.Bus449_TestDataSet();
            this.oncall_CalendarTableAdapter = new Bus449Proj.Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();
            this.tableAdapterManager = new Bus449Proj.Bus449_TestDataSetTableAdapters.TableAdapterManager();
            this.oncall_CalendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bus449_TestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncall_CalendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(413, 215);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(75, 23);
            this.mainButton.TabIndex = 1;
            this.mainButton.Text = "Main Menu";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // bus449_TestDataSet
            // 
            this.bus449_TestDataSet.DataSetName = "Bus449_TestDataSet";
            this.bus449_TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oncall_CalendarTableAdapter
            // 
            this.oncall_CalendarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.Oncall_CalendarTableAdapter = this.oncall_CalendarTableAdapter;
            this.tableAdapterManager.UpdateOrder = Bus449Proj.Bus449_TestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oncall_CalendarBindingSource
            // 
            this.oncall_CalendarBindingSource.DataMember = "Oncall_Calendar";
            this.oncall_CalendarBindingSource.DataSource = this.bus449_TestDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Bus449Proj.Properties.Resources.cn_logo_full_w;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.bus449_TestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncall_CalendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button mainButton;
        private Bus449_TestDataSet bus449_TestDataSet;
        private Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter oncall_CalendarTableAdapter;
        private Bus449_TestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource oncall_CalendarBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
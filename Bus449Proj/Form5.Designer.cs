﻿namespace Bus449Proj
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label date_IDLabel;
            System.Windows.Forms.Label l_NameLabel;
            System.Windows.Forms.Label f_NameLabel;
            System.Windows.Forms.Label l_NameLabel1;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.mainButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.switchButton = new System.Windows.Forms.Button();
            this.bus449_TestDataSet = new Bus449Proj.Bus449_TestDataSet();
            this.employeeTableAdapter = new Bus449Proj.Bus449_TestDataSetTableAdapters.EmployeeTableAdapter();
            this.oncall_CalendarTableAdapter = new Bus449Proj.Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();
            this.tableAdapterManager = new Bus449Proj.Bus449_TestDataSetTableAdapters.TableAdapterManager();
            this.oncall_CalendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.switchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.l_NameComboBox = new System.Windows.Forms.ComboBox();
            this.employeeOncallCalendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f_NameLabel1 = new System.Windows.Forms.Label();
            this.employeeOncallCalendarPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newlnameComboBox = new System.Windows.Forms.ComboBox();
            this.fnameLabel2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            date_IDLabel = new System.Windows.Forms.Label();
            l_NameLabel = new System.Windows.Forms.Label();
            f_NameLabel = new System.Windows.Forms.Label();
            l_NameLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bus449_TestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncall_CalendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeOncallCalendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeOncallCalendarPBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_IDLabel
            // 
            date_IDLabel.AutoSize = true;
            date_IDLabel.Location = new System.Drawing.Point(5, 21);
            date_IDLabel.Name = "date_IDLabel";
            date_IDLabel.Size = new System.Drawing.Size(68, 13);
            date_IDLabel.TabIndex = 4;
            date_IDLabel.Text = "Switch Date:";
            // 
            // l_NameLabel
            // 
            l_NameLabel.AutoSize = true;
            l_NameLabel.Location = new System.Drawing.Point(6, 16);
            l_NameLabel.Name = "l_NameLabel";
            l_NameLabel.Size = new System.Drawing.Size(47, 13);
            l_NameLabel.TabIndex = 6;
            l_NameLabel.Text = "L Name:";
            // 
            // f_NameLabel
            // 
            f_NameLabel.AutoSize = true;
            f_NameLabel.Location = new System.Drawing.Point(6, 43);
            f_NameLabel.Name = "f_NameLabel";
            f_NameLabel.Size = new System.Drawing.Size(47, 13);
            f_NameLabel.TabIndex = 8;
            f_NameLabel.Text = "F Name:";
            // 
            // l_NameLabel1
            // 
            l_NameLabel1.AutoSize = true;
            l_NameLabel1.Location = new System.Drawing.Point(6, 16);
            l_NameLabel1.Name = "l_NameLabel1";
            l_NameLabel1.Size = new System.Drawing.Size(47, 13);
            l_NameLabel1.TabIndex = 10;
            l_NameLabel1.Text = "L Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 13);
            label1.TabIndex = 15;
            label1.Text = "F Name:";
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(302, 128);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(75, 23);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "Main Menu";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(383, 128);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(302, 90);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(156, 32);
            this.switchButton.TabIndex = 2;
            this.switchButton.Text = "Switch";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // bus449_TestDataSet
            // 
            this.bus449_TestDataSet.DataSetName = "Bus449_TestDataSet";
            this.bus449_TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // oncall_CalendarTableAdapter
            // 
            this.oncall_CalendarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.Oncall_CalendarTableAdapter = this.oncall_CalendarTableAdapter;
            this.tableAdapterManager.UpdateOrder = Bus449Proj.Bus449_TestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oncall_CalendarBindingSource
            // 
            this.oncall_CalendarBindingSource.DataMember = "Oncall_Calendar";
            this.oncall_CalendarBindingSource.DataSource = this.bus449_TestDataSet;
            // 
            // switchDateTimePicker
            // 
            this.switchDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.oncall_CalendarBindingSource, "Date_ID", true));
            this.switchDateTimePicker.Location = new System.Drawing.Point(77, 18);
            this.switchDateTimePicker.Name = "switchDateTimePicker";
            this.switchDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.switchDateTimePicker.TabIndex = 5;
            this.switchDateTimePicker.Value = new System.DateTime(2018, 3, 20, 0, 0, 0, 0);
            this.switchDateTimePicker.ValueChanged += new System.EventHandler(this.switchDateTimePicker_ValueChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.bus449_TestDataSet;
            // 
            // l_NameComboBox
            // 
            this.l_NameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "L_Name", true));
            this.l_NameComboBox.FormattingEnabled = true;
            this.l_NameComboBox.Location = new System.Drawing.Point(59, 13);
            this.l_NameComboBox.Name = "l_NameComboBox";
            this.l_NameComboBox.Size = new System.Drawing.Size(160, 21);
            this.l_NameComboBox.TabIndex = 7;
            this.l_NameComboBox.TextChanged += new System.EventHandler(this.l_NameComboBox_TextChanged);
            // 
            // employeeOncallCalendarBindingSource
            // 
            this.employeeOncallCalendarBindingSource.DataMember = "EmployeeOncall_Calendar";
            this.employeeOncallCalendarBindingSource.DataSource = this.oncall_CalendarBindingSource;
            // 
            // f_NameLabel1
            // 
            this.f_NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f_NameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "F_Name", true));
            this.f_NameLabel1.Location = new System.Drawing.Point(59, 37);
            this.f_NameLabel1.Name = "f_NameLabel1";
            this.f_NameLabel1.Size = new System.Drawing.Size(160, 23);
            this.f_NameLabel1.TabIndex = 9;
            this.f_NameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // employeeOncallCalendarPBindingSource
            // 
            this.employeeOncallCalendarPBindingSource.DataMember = "EmployeeOncall_CalendarP";
            this.employeeOncallCalendarPBindingSource.DataSource = this.oncall_CalendarBindingSource;
            // 
            // newlnameComboBox
            // 
            this.newlnameComboBox.FormattingEnabled = true;
            this.newlnameComboBox.Location = new System.Drawing.Point(59, 13);
            this.newlnameComboBox.Name = "newlnameComboBox";
            this.newlnameComboBox.Size = new System.Drawing.Size(150, 21);
            this.newlnameComboBox.TabIndex = 14;
            this.newlnameComboBox.TextChanged += new System.EventHandler(this.newlnameComboBox_TextChanged);
            // 
            // fnameLabel2
            // 
            this.fnameLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnameLabel2.Location = new System.Drawing.Point(59, 37);
            this.fnameLabel2.Name = "fnameLabel2";
            this.fnameLabel2.Size = new System.Drawing.Size(150, 23);
            this.fnameLabel2.TabIndex = 16;
            this.fnameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_NameComboBox);
            this.groupBox1.Controls.Add(l_NameLabel);
            this.groupBox1.Controls.Add(this.f_NameLabel1);
            this.groupBox1.Controls.Add(f_NameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 74);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newlnameComboBox);
            this.groupBox2.Controls.Add(l_NameLabel1);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.fnameLabel2);
            this.groupBox2.Location = new System.Drawing.Point(243, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 74);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Person 2";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(date_IDLabel);
            this.panel1.Controls.Add(this.switchDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 59);
            this.panel1.TabIndex = 19;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 164);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mainButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Switch";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bus449_TestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncall_CalendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeOncallCalendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeOncallCalendarPBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button switchButton;
        private Bus449_TestDataSet bus449_TestDataSet;
        private Bus449_TestDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter oncall_CalendarTableAdapter;
        private Bus449_TestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource oncall_CalendarBindingSource;
        private System.Windows.Forms.DateTimePicker switchDateTimePicker;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.ComboBox l_NameComboBox;
        private System.Windows.Forms.Label f_NameLabel1;
        private System.Windows.Forms.BindingSource employeeOncallCalendarPBindingSource;
        private System.Windows.Forms.ComboBox newlnameComboBox;
        private System.Windows.Forms.BindingSource employeeOncallCalendarBindingSource;
        private System.Windows.Forms.Label fnameLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
    }
}
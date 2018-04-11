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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label holiday_descLabel;
            this.label2 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.holidaysListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.startdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.holidayTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clearButton = new System.Windows.Forms.Button();
            this.bus449_TestDataSet = new Bus449Proj.Bus449_TestDataSet();
            this.oncall_CalendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oncall_CalendarTableAdapter = new Bus449Proj.Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();
            this.tableAdapterManager = new Bus449Proj.Bus449_TestDataSetTableAdapters.TableAdapterManager();
            this.holiday_descTextBox = new System.Windows.Forms.TextBox();
            this.employeeTableAdapter = new Bus449Proj.Bus449_TestDataSetTableAdapters.EmployeeTableAdapter();
            holiday_descLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bus449_TestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncall_CalendarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // holiday_descLabel
            // 
            holiday_descLabel.AutoSize = true;
            holiday_descLabel.Location = new System.Drawing.Point(302, 25);
            holiday_descLabel.Name = "holiday_descLabel";
            holiday_descLabel.Size = new System.Drawing.Size(45, 13);
            holiday_descLabel.TabIndex = 21;
            holiday_descLabel.Text = "Holiday:";
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
            this.createButton.Location = new System.Drawing.Point(16, 275);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(100, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create Schedule";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(411, 275);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(280, 275);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(111, 23);
            this.mainButton.TabIndex = 10;
            this.mainButton.Text = "Main Menu";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Holiday Date:";
            // 
            // holidaysListBox
            // 
            this.holidaysListBox.FormattingEnabled = true;
            this.holidaysListBox.Location = new System.Drawing.Point(305, 117);
            this.holidaysListBox.Name = "holidaysListBox";
            this.holidaysListBox.Size = new System.Drawing.Size(208, 134);
            this.holidaysListBox.TabIndex = 15;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(379, 88);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(134, 23);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Add Holiday";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            // startdateTimePicker
            // 
            this.startdateTimePicker.Location = new System.Drawing.Point(77, 51);
            this.startdateTimePicker.Name = "startdateTimePicker";
            this.startdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startdateTimePicker.TabIndex = 17;
            this.startdateTimePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.startdateTimePicker.ValueChanged += new System.EventHandler(this.startdateTimePicker_ValueChanged);
            // 
            // enddateTimePicker
            // 
            this.enddateTimePicker.Location = new System.Drawing.Point(77, 105);
            this.enddateTimePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.enddateTimePicker.Name = "enddateTimePicker";
            this.enddateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.enddateTimePicker.TabIndex = 18;
            this.enddateTimePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // holidayTimePicker
            // 
            this.holidayTimePicker.Location = new System.Drawing.Point(379, 51);
            this.holidayTimePicker.Name = "holidayTimePicker";
            this.holidayTimePicker.Size = new System.Drawing.Size(205, 20);
            this.holidayTimePicker.TabIndex = 19;
            this.holidayTimePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(141, 275);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(113, 23);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "Clear Schedule";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // bus449_TestDataSet
            // 
            this.bus449_TestDataSet.DataSetName = "Bus449_TestDataSet";
            this.bus449_TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oncall_CalendarBindingSource
            // 
            this.oncall_CalendarBindingSource.DataMember = "Oncall_Calendar";
            this.oncall_CalendarBindingSource.DataSource = this.bus449_TestDataSet;
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
            // holiday_descTextBox
            // 
            this.holiday_descTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oncall_CalendarBindingSource, "holiday_desc", true));
            this.holiday_descTextBox.Location = new System.Drawing.Point(377, 22);
            this.holiday_descTextBox.Name = "holiday_descTextBox";
            this.holiday_descTextBox.Size = new System.Drawing.Size(100, 20);
            this.holiday_descTextBox.TabIndex = 22;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 343);
            this.Controls.Add(holiday_descLabel);
            this.Controls.Add(this.holiday_descTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.holidayTimePicker);
            this.Controls.Add(this.enddateTimePicker);
            this.Controls.Add(this.startdateTimePicker);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.holidaysListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Schedule";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bus449_TestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncall_CalendarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox holidaysListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startdateTimePicker;
        private System.Windows.Forms.DateTimePicker enddateTimePicker;
        private System.Windows.Forms.DateTimePicker holidayTimePicker;
        private System.Windows.Forms.Button clearButton;
        private Bus449_TestDataSet bus449_TestDataSet;
        private System.Windows.Forms.BindingSource oncall_CalendarBindingSource;
        private Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter oncall_CalendarTableAdapter;
        private Bus449_TestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox holiday_descTextBox;
        private Bus449_TestDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}
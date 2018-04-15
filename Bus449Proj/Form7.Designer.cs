namespace Bus449Proj
{
    partial class Form7
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
            System.Windows.Forms.Label empid_amLabel;
            System.Windows.Forms.Label empid_pmLabel;
            System.Windows.Forms.Label holidayLabel;
            System.Windows.Forms.Label holiday_descLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.bus449_TestDataSet = new Bus449Proj.Bus449_TestDataSet();
            this.oncall_CalendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oncall_CalendarTableAdapter = new Bus449Proj.Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();
            this.tableAdapterManager = new Bus449Proj.Bus449_TestDataSetTableAdapters.TableAdapterManager();
            this.oncall_CalendarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.oncall_CalendarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.date_IDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.empid_amTextBox = new System.Windows.Forms.TextBox();
            this.empid_pmTextBox = new System.Windows.Forms.TextBox();
            this.mainButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.holidayCheckBox = new System.Windows.Forms.CheckBox();
            this.holiday_descTextBox = new System.Windows.Forms.TextBox();
            date_IDLabel = new System.Windows.Forms.Label();
            empid_amLabel = new System.Windows.Forms.Label();
            empid_pmLabel = new System.Windows.Forms.Label();
            holidayLabel = new System.Windows.Forms.Label();
            holiday_descLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bus449_TestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncall_CalendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncall_CalendarBindingNavigator)).BeginInit();
            this.oncall_CalendarBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_IDLabel
            // 
            date_IDLabel.AutoSize = true;
            date_IDLabel.Location = new System.Drawing.Point(11, 48);
            date_IDLabel.Name = "date_IDLabel";
            date_IDLabel.Size = new System.Drawing.Size(47, 13);
            date_IDLabel.TabIndex = 1;
            date_IDLabel.Text = "Date ID:";
            // 
            // empid_amLabel
            // 
            empid_amLabel.AutoSize = true;
            empid_amLabel.Location = new System.Drawing.Point(12, 95);
            empid_amLabel.Name = "empid_amLabel";
            empid_amLabel.Size = new System.Drawing.Size(55, 13);
            empid_amLabel.TabIndex = 3;
            empid_amLabel.Text = "empid am:";
            // 
            // empid_pmLabel
            // 
            empid_pmLabel.AutoSize = true;
            empid_pmLabel.Location = new System.Drawing.Point(12, 139);
            empid_pmLabel.Name = "empid_pmLabel";
            empid_pmLabel.Size = new System.Drawing.Size(55, 13);
            empid_pmLabel.TabIndex = 5;
            empid_pmLabel.Text = "empid pm:";
            // 
            // holidayLabel
            // 
            holidayLabel.AutoSize = true;
            holidayLabel.Location = new System.Drawing.Point(15, 181);
            holidayLabel.Name = "holidayLabel";
            holidayLabel.Size = new System.Drawing.Size(43, 13);
            holidayLabel.TabIndex = 9;
            holidayLabel.Text = "holiday:";
            // 
            // holiday_descLabel
            // 
            holiday_descLabel.AutoSize = true;
            holiday_descLabel.Location = new System.Drawing.Point(11, 218);
            holiday_descLabel.Name = "holiday_descLabel";
            holiday_descLabel.Size = new System.Drawing.Size(69, 13);
            holiday_descLabel.TabIndex = 11;
            holiday_descLabel.Text = "holiday desc:";
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
            // oncall_CalendarBindingNavigator
            // 
            this.oncall_CalendarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oncall_CalendarBindingNavigator.BindingSource = this.oncall_CalendarBindingSource;
            this.oncall_CalendarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.oncall_CalendarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.oncall_CalendarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.oncall_CalendarBindingNavigatorSaveItem});
            this.oncall_CalendarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.oncall_CalendarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.oncall_CalendarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.oncall_CalendarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.oncall_CalendarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.oncall_CalendarBindingNavigator.Name = "oncall_CalendarBindingNavigator";
            this.oncall_CalendarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.oncall_CalendarBindingNavigator.Size = new System.Drawing.Size(351, 25);
            this.oncall_CalendarBindingNavigator.TabIndex = 0;
            this.oncall_CalendarBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // oncall_CalendarBindingNavigatorSaveItem
            // 
            this.oncall_CalendarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oncall_CalendarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oncall_CalendarBindingNavigatorSaveItem.Image")));
            this.oncall_CalendarBindingNavigatorSaveItem.Name = "oncall_CalendarBindingNavigatorSaveItem";
            this.oncall_CalendarBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.oncall_CalendarBindingNavigatorSaveItem.Text = "Save Data";
            this.oncall_CalendarBindingNavigatorSaveItem.Click += new System.EventHandler(this.oncall_CalendarBindingNavigatorSaveItem_Click);
            // 
            // date_IDDateTimePicker
            // 
            this.date_IDDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.oncall_CalendarBindingSource, "Date_ID", true));
            this.date_IDDateTimePicker.Location = new System.Drawing.Point(64, 44);
            this.date_IDDateTimePicker.Name = "date_IDDateTimePicker";
            this.date_IDDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_IDDateTimePicker.TabIndex = 2;
            // 
            // empid_amTextBox
            // 
            this.empid_amTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oncall_CalendarBindingSource, "empid_am", true));
            this.empid_amTextBox.Location = new System.Drawing.Point(73, 95);
            this.empid_amTextBox.Name = "empid_amTextBox";
            this.empid_amTextBox.Size = new System.Drawing.Size(100, 20);
            this.empid_amTextBox.TabIndex = 4;
            // 
            // empid_pmTextBox
            // 
            this.empid_pmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oncall_CalendarBindingSource, "empid_pm", true));
            this.empid_pmTextBox.Location = new System.Drawing.Point(73, 136);
            this.empid_pmTextBox.Name = "empid_pmTextBox";
            this.empid_pmTextBox.Size = new System.Drawing.Size(100, 20);
            this.empid_pmTextBox.TabIndex = 6;
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(228, 228);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(75, 23);
            this.mainButton.TabIndex = 7;
            this.mainButton.Text = "Main";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(228, 269);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // holidayCheckBox
            // 
            this.holidayCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.oncall_CalendarBindingSource, "holiday", true));
            this.holidayCheckBox.Location = new System.Drawing.Point(73, 176);
            this.holidayCheckBox.Name = "holidayCheckBox";
            this.holidayCheckBox.Size = new System.Drawing.Size(104, 24);
            this.holidayCheckBox.TabIndex = 10;
            this.holidayCheckBox.Text = "checkBox1";
            this.holidayCheckBox.UseVisualStyleBackColor = true;
            // 
            // holiday_descTextBox
            // 
            this.holiday_descTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oncall_CalendarBindingSource, "holiday_desc", true));
            this.holiday_descTextBox.Location = new System.Drawing.Point(86, 211);
            this.holiday_descTextBox.Name = "holiday_descTextBox";
            this.holiday_descTextBox.Size = new System.Drawing.Size(100, 20);
            this.holiday_descTextBox.TabIndex = 12;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 315);
            this.Controls.Add(holiday_descLabel);
            this.Controls.Add(this.holiday_descTextBox);
            this.Controls.Add(holidayLabel);
            this.Controls.Add(this.holidayCheckBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(empid_pmLabel);
            this.Controls.Add(this.empid_pmTextBox);
            this.Controls.Add(empid_amLabel);
            this.Controls.Add(this.empid_amTextBox);
            this.Controls.Add(date_IDLabel);
            this.Controls.Add(this.date_IDDateTimePicker);
            this.Controls.Add(this.oncall_CalendarBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bus449_TestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncall_CalendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncall_CalendarBindingNavigator)).EndInit();
            this.oncall_CalendarBindingNavigator.ResumeLayout(false);
            this.oncall_CalendarBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bus449_TestDataSet bus449_TestDataSet;
        private System.Windows.Forms.BindingSource oncall_CalendarBindingSource;
        private Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter oncall_CalendarTableAdapter;
        private Bus449_TestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator oncall_CalendarBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton oncall_CalendarBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker date_IDDateTimePicker;
        private System.Windows.Forms.TextBox empid_amTextBox;
        private System.Windows.Forms.TextBox empid_pmTextBox;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox holidayCheckBox;
        private System.Windows.Forms.TextBox holiday_descTextBox;
    }
}
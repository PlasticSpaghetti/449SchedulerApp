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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label date_IDLabel;
            System.Windows.Forms.Label l_NameLabel;
            System.Windows.Forms.Label f_NameLabel;
            System.Windows.Forms.Label l_NameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.mainButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.switchButton = new System.Windows.Forms.Button();
            this.bus449_TestDataSet = new Bus449Proj.Bus449_TestDataSet();
            this.employeeTableAdapter = new Bus449Proj.Bus449_TestDataSetTableAdapters.EmployeeTableAdapter();
            this.oncall_CalendarTableAdapter = new Bus449Proj.Bus449_TestDataSetTableAdapters.Oncall_CalendarTableAdapter();
            this.tableAdapterManager = new Bus449Proj.Bus449_TestDataSetTableAdapters.TableAdapterManager();
            this.oncall_CalendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.switchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.l_NameComboBox = new System.Windows.Forms.ComboBox();
            this.f_NameLabel1 = new System.Windows.Forms.Label();
            this.employeeOncallCalendarPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newlnameComboBox = new System.Windows.Forms.ComboBox();
            this.employeeOncallCalendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            date_IDLabel = new System.Windows.Forms.Label();
            l_NameLabel = new System.Windows.Forms.Label();
            f_NameLabel = new System.Windows.Forms.Label();
            l_NameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bus449_TestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncall_CalendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncall_CalendarBindingNavigator)).BeginInit();
            this.oncall_CalendarBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeOncallCalendarPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeOncallCalendarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // date_IDLabel
            // 
            date_IDLabel.AutoSize = true;
            date_IDLabel.Location = new System.Drawing.Point(17, 139);
            date_IDLabel.Name = "date_IDLabel";
            date_IDLabel.Size = new System.Drawing.Size(68, 13);
            date_IDLabel.TabIndex = 4;
            date_IDLabel.Text = "Switch Date:";
            // 
            // l_NameLabel
            // 
            l_NameLabel.AutoSize = true;
            l_NameLabel.Location = new System.Drawing.Point(34, 46);
            l_NameLabel.Name = "l_NameLabel";
            l_NameLabel.Size = new System.Drawing.Size(47, 13);
            l_NameLabel.TabIndex = 6;
            l_NameLabel.Text = "L Name:";
            // 
            // f_NameLabel
            // 
            f_NameLabel.AutoSize = true;
            f_NameLabel.Location = new System.Drawing.Point(34, 83);
            f_NameLabel.Name = "f_NameLabel";
            f_NameLabel.Size = new System.Drawing.Size(47, 13);
            f_NameLabel.TabIndex = 8;
            f_NameLabel.Text = "F Name:";
            // 
            // l_NameLabel1
            // 
            l_NameLabel1.AutoSize = true;
            l_NameLabel1.Location = new System.Drawing.Point(321, 41);
            l_NameLabel1.Name = "l_NameLabel1";
            l_NameLabel1.Size = new System.Drawing.Size(47, 13);
            l_NameLabel1.TabIndex = 10;
            l_NameLabel1.Text = "L Name:";
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
            this.oncall_CalendarBindingNavigator.Size = new System.Drawing.Size(598, 25);
            this.oncall_CalendarBindingNavigator.TabIndex = 3;
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
            // switchDateTimePicker
            // 
            this.switchDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.oncall_CalendarBindingSource, "Date_ID", true));
            this.switchDateTimePicker.Location = new System.Drawing.Point(91, 133);
            this.switchDateTimePicker.Name = "switchDateTimePicker";
            this.switchDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.switchDateTimePicker.TabIndex = 5;
            this.switchDateTimePicker.Value = new System.DateTime(2018, 3, 20, 0, 0, 0, 0);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.bus449_TestDataSet;
            // 
            // l_NameComboBox
            // 
            this.l_NameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "L_Name", true));
            this.l_NameComboBox.DataSource = this.employeeOncallCalendarBindingSource;
            this.l_NameComboBox.DisplayMember = "L_Name";
            this.l_NameComboBox.FormattingEnabled = true;
            this.l_NameComboBox.Location = new System.Drawing.Point(87, 43);
            this.l_NameComboBox.Name = "l_NameComboBox";
            this.l_NameComboBox.Size = new System.Drawing.Size(121, 21);
            this.l_NameComboBox.TabIndex = 7;
            // 
            // f_NameLabel1
            // 
            this.f_NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f_NameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "F_Name", true));
            this.f_NameLabel1.Location = new System.Drawing.Point(87, 83);
            this.f_NameLabel1.Name = "f_NameLabel1";
            this.f_NameLabel1.Size = new System.Drawing.Size(100, 23);
            this.f_NameLabel1.TabIndex = 9;
            // 
            // employeeOncallCalendarPBindingSource
            // 
            this.employeeOncallCalendarPBindingSource.DataMember = "EmployeeOncall_CalendarP";
            this.employeeOncallCalendarPBindingSource.DataSource = this.oncall_CalendarBindingSource;
            // 
            // newlnameComboBox
            // 
            this.newlnameComboBox.FormattingEnabled = true;
            this.newlnameComboBox.Location = new System.Drawing.Point(374, 38);
            this.newlnameComboBox.Name = "newlnameComboBox";
            this.newlnameComboBox.Size = new System.Drawing.Size(121, 21);
            this.newlnameComboBox.TabIndex = 14;
            // 
            // employeeOncallCalendarBindingSource
            // 
            this.employeeOncallCalendarBindingSource.DataMember = "EmployeeOncall_Calendar";
            this.employeeOncallCalendarBindingSource.DataSource = this.oncall_CalendarBindingSource;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 278);
            this.Controls.Add(this.newlnameComboBox);
            this.Controls.Add(l_NameLabel1);
            this.Controls.Add(f_NameLabel);
            this.Controls.Add(this.f_NameLabel1);
            this.Controls.Add(l_NameLabel);
            this.Controls.Add(this.l_NameComboBox);
            this.Controls.Add(date_IDLabel);
            this.Controls.Add(this.switchDateTimePicker);
            this.Controls.Add(this.oncall_CalendarBindingNavigator);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mainButton);
            this.Name = "Form5";
            this.Text = "Switch";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bus449_TestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncall_CalendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncall_CalendarBindingNavigator)).EndInit();
            this.oncall_CalendarBindingNavigator.ResumeLayout(false);
            this.oncall_CalendarBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeOncallCalendarPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeOncallCalendarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DateTimePicker switchDateTimePicker;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.ComboBox l_NameComboBox;
        private System.Windows.Forms.Label f_NameLabel1;
        private System.Windows.Forms.BindingSource employeeOncallCalendarPBindingSource;
        private System.Windows.Forms.ComboBox newlnameComboBox;
        private System.Windows.Forms.BindingSource employeeOncallCalendarBindingSource;
    }
}
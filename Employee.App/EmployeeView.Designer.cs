namespace Employee.App
{
    partial class EmployeeView
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

        #region Windows Form Desi#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.employeeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.City_txt = new System.Windows.Forms.TextBox();
            this.Department_txt = new System.Windows.Forms.TextBox();
            this.Gender_ComboBox = new System.Windows.Forms.ComboBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.Next_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeModelBindingSource
            // 
            this.employeeModelBindingSource.DataSource = typeof(Employee.Domain.Entities.EmployeeModel);
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(141, 33);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.PlaceholderText = "Abbos";
            this.Name_txt.Size = new System.Drawing.Size(267, 23);
            this.Name_txt.TabIndex = 4;
            // 
            // City_txt
            // 
            this.City_txt.Location = new System.Drawing.Point(141, 62);
            this.City_txt.Name = "City_txt";
            this.City_txt.PlaceholderText = "Tashkent";
            this.City_txt.Size = new System.Drawing.Size(267, 23);
            this.City_txt.TabIndex = 5;
            // 
            // Department_txt
            // 
            this.Department_txt.Location = new System.Drawing.Point(141, 91);
            this.Department_txt.Name = "Department_txt";
            this.Department_txt.PlaceholderText = "Development";
            this.Department_txt.Size = new System.Drawing.Size(267, 23);
            this.Department_txt.TabIndex = 6;
            // 
            // Gender_ComboBox
            // 
            this.Gender_ComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.Gender_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender_ComboBox.FormattingEnabled = true;
            this.Gender_ComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender_ComboBox.Location = new System.Drawing.Point(141, 120);
            this.Gender_ComboBox.Name = "Gender_ComboBox";
            this.Gender_ComboBox.Size = new System.Drawing.Size(267, 23);
            this.Gender_ComboBox.TabIndex = 7;
            // 
            // Save_btn
            // 
            this.Save_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_btn.Location = new System.Drawing.Point(1, 170);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(94, 34);
            this.Save_btn.TabIndex = 8;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear_btn.Location = new System.Drawing.Point(101, 170);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(104, 34);
            this.Clear_btn.TabIndex = 9;
            this.Clear_btn.Text = "Delete all";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Delete_btn.Location = new System.Drawing.Point(211, 170);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(103, 34);
            this.Delete_btn.TabIndex = 10;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.currentCityDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.genderTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeModelBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 225);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(418, 331);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 35;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 95;
            // 
            // currentCityDataGridViewTextBoxColumn
            // 
            this.currentCityDataGridViewTextBoxColumn.DataPropertyName = "CurrentCity";
            this.currentCityDataGridViewTextBoxColumn.HeaderText = "City";
            this.currentCityDataGridViewTextBoxColumn.Name = "currentCityDataGridViewTextBoxColumn";
            this.currentCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentCityDataGridViewTextBoxColumn.Width = 90;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentDataGridViewTextBoxColumn.Width = 85;
            // 
            // genderTypeDataGridViewTextBoxColumn
            // 
            this.genderTypeDataGridViewTextBoxColumn.DataPropertyName = "GenderType";
            this.genderTypeDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderTypeDataGridViewTextBoxColumn.Name = "genderTypeDataGridViewTextBoxColumn";
            this.genderTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderTypeDataGridViewTextBoxColumn.Width = 68;
            // 
            // employeeModelBindingSource1
            // 
            this.employeeModelBindingSource1.DataSource = typeof(Employee.Domain.Entities.EmployeeModel);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Current City";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gender";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(320, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(118, 565);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(75, 23);
            this.Back_btn.TabIndex = 17;
            this.Back_btn.Text = "< Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Next_btn
            // 
            this.Next_btn.Location = new System.Drawing.Point(211, 565);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(75, 23);
            this.Next_btn.TabIndex = 18;
            this.Next_btn.Text = "Next >";
            this.Next_btn.UseVisualStyleBackColor = true;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 600);
            this.Controls.Add(this.Next_btn);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Gender_ComboBox);
            this.Controls.Add(this.Department_txt);
            this.Controls.Add(this.City_txt);
            this.Controls.Add(this.Name_txt);
            this.Name = "EmployeeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee app";
            this.Load += new System.EventHandler(this.EmployeeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeModelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox Name_txt;
        private TextBox City_txt;
        private TextBox Department_txt;
        private ComboBox Gender_ComboBox;
        private Button Save_btn;
        private Button Clear_btn;
        private Button Delete_btn;
        private BindingSource employeeModelBindingSource;
        private DataGridView dataGridView1;
        private BindingSource employeeModelBindingSource1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentCityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderTypeDataGridViewTextBoxColumn;
        private Button button1;
        private Button Back_btn;
        private Button Next_btn;
    }
}
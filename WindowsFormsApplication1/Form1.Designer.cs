namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeSerialize = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.gBoxStudentDetails = new System.Windows.Forms.GroupBox();
            this.lblGroupID = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.checkBoxFulltime = new System.Windows.Forms.CheckBox();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.txtStudentLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxGroupID = new System.Windows.Forms.ComboBox();
            this.lblStudentLastName = new System.Windows.Forms.Label();
            this.txtStudentFName = new System.Windows.Forms.TextBox();
            this.lblStudentFName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.buttonSortByStudentName = new System.Windows.Forms.Button();
            this.buttonSortByStudentD = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.txtGroupID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnImportCSV = new System.Windows.Forms.Button();
            this.txtGroupIDPrefix = new System.Windows.Forms.TextBox();
            this.btnBulkAssign = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.GroupBox();
            this.btnUpdateGroupTable = new System.Windows.Forms.Button();
            this.cmbDisplayGroup = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gBoxSort = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBoxStudentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Enter.SuspendLayout();
            this.gBoxSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(15, 104);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(103, 23);
            this.btnSerialize.TabIndex = 2;
            this.btnSerialize.Text = "Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeSerialize
            // 
            this.btnDeSerialize.Location = new System.Drawing.Point(15, 142);
            this.btnDeSerialize.Name = "btnDeSerialize";
            this.btnDeSerialize.Size = new System.Drawing.Size(103, 22);
            this.btnDeSerialize.TabIndex = 3;
            this.btnDeSerialize.Text = "De-serialize";
            this.btnDeSerialize.UseVisualStyleBackColor = true;
            this.btnDeSerialize.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 28);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(456, 160);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(17, 229);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(264, 23);
            this.buttonAddStudent.TabIndex = 10;
            this.buttonAddStudent.Text = "Add/Update Student Record";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // gBoxStudentDetails
            // 
            this.gBoxStudentDetails.Controls.Add(this.lblGroupID);
            this.gBoxStudentDetails.Controls.Add(this.txtEmail);
            this.gBoxStudentDetails.Controls.Add(this.checkBoxFulltime);
            this.gBoxStudentDetails.Controls.Add(this.lblStudentEmail);
            this.gBoxStudentDetails.Controls.Add(this.txtStudentLName);
            this.gBoxStudentDetails.Controls.Add(this.label3);
            this.gBoxStudentDetails.Controls.Add(this.cmbBoxGroupID);
            this.gBoxStudentDetails.Controls.Add(this.lblStudentLastName);
            this.gBoxStudentDetails.Controls.Add(this.buttonAddStudent);
            this.gBoxStudentDetails.Controls.Add(this.txtStudentFName);
            this.gBoxStudentDetails.Controls.Add(this.lblStudentFName);
            this.gBoxStudentDetails.Controls.Add(this.lblStudentID);
            this.gBoxStudentDetails.Controls.Add(this.txtStudentID);
            this.gBoxStudentDetails.Location = new System.Drawing.Point(41, 212);
            this.gBoxStudentDetails.Name = "gBoxStudentDetails";
            this.gBoxStudentDetails.Size = new System.Drawing.Size(303, 270);
            this.gBoxStudentDetails.TabIndex = 11;
            this.gBoxStudentDetails.TabStop = false;
            this.gBoxStudentDetails.Text = "Student Details";
            this.gBoxStudentDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblGroupID
            // 
            this.lblGroupID.AutoSize = true;
            this.lblGroupID.Location = new System.Drawing.Point(14, 159);
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.Size = new System.Drawing.Size(53, 13);
            this.lblGroupID.TabIndex = 20;
            this.lblGroupID.Text = "Group ID:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // checkBoxFulltime
            // 
            this.checkBoxFulltime.AutoSize = true;
            this.checkBoxFulltime.Location = new System.Drawing.Point(266, 193);
            this.checkBoxFulltime.Name = "checkBoxFulltime";
            this.checkBoxFulltime.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFulltime.TabIndex = 14;
            this.checkBoxFulltime.UseVisualStyleBackColor = true;
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Location = new System.Drawing.Point(14, 128);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(76, 13);
            this.lblStudentEmail.TabIndex = 18;
            this.lblStudentEmail.Text = "Email Address:";
            // 
            // txtStudentLName
            // 
            this.txtStudentLName.Location = new System.Drawing.Point(122, 94);
            this.txtStudentLName.Name = "txtStudentLName";
            this.txtStudentLName.Size = new System.Drawing.Size(159, 20);
            this.txtStudentLName.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Is the student in full-time study?";
            // 
            // cmbBoxGroupID
            // 
            this.cmbBoxGroupID.FormattingEnabled = true;
            this.cmbBoxGroupID.Location = new System.Drawing.Point(122, 156);
            this.cmbBoxGroupID.Name = "cmbBoxGroupID";
            this.cmbBoxGroupID.Size = new System.Drawing.Size(159, 21);
            this.cmbBoxGroupID.TabIndex = 16;
            this.cmbBoxGroupID.SelectedIndexChanged += new System.EventHandler(this.cmbDisplayGroup_SelectedIndexChanged);
            // 
            // lblStudentLastName
            // 
            this.lblStudentLastName.AutoSize = true;
            this.lblStudentLastName.Location = new System.Drawing.Point(14, 94);
            this.lblStudentLastName.Name = "lblStudentLastName";
            this.lblStudentLastName.Size = new System.Drawing.Size(101, 13);
            this.lblStudentLastName.TabIndex = 15;
            this.lblStudentLastName.Text = "Student Last Name:";
            // 
            // txtStudentFName
            // 
            this.txtStudentFName.Location = new System.Drawing.Point(122, 63);
            this.txtStudentFName.Name = "txtStudentFName";
            this.txtStudentFName.Size = new System.Drawing.Size(159, 20);
            this.txtStudentFName.TabIndex = 12;
            this.txtStudentFName.Text = "Quan Dang";
            // 
            // lblStudentFName
            // 
            this.lblStudentFName.AutoSize = true;
            this.lblStudentFName.Location = new System.Drawing.Point(14, 66);
            this.lblStudentFName.Name = "lblStudentFName";
            this.lblStudentFName.Size = new System.Drawing.Size(100, 13);
            this.lblStudentFName.TabIndex = 11;
            this.lblStudentFName.Text = "Student First Name:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(14, 36);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(61, 13);
            this.lblStudentID.TabIndex = 10;
            this.lblStudentID.Text = "Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(122, 32);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(159, 20);
            this.txtStudentID.TabIndex = 9;
            this.txtStudentID.Text = "1";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(976, 459);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSortByStudentName
            // 
            this.buttonSortByStudentName.Location = new System.Drawing.Point(15, 66);
            this.buttonSortByStudentName.Name = "buttonSortByStudentName";
            this.buttonSortByStudentName.Size = new System.Drawing.Size(103, 23);
            this.buttonSortByStudentName.TabIndex = 13;
            this.buttonSortByStudentName.Text = "Sort by Name";
            this.buttonSortByStudentName.UseVisualStyleBackColor = true;
            this.buttonSortByStudentName.Click += new System.EventHandler(this.buttonSortByEmpName_Click);
            // 
            // buttonSortByStudentD
            // 
            this.buttonSortByStudentD.Location = new System.Drawing.Point(15, 32);
            this.buttonSortByStudentD.Name = "buttonSortByStudentD";
            this.buttonSortByStudentD.Size = new System.Drawing.Size(103, 23);
            this.buttonSortByStudentD.TabIndex = 14;
            this.buttonSortByStudentD.Text = "Sort By StudentID";
            this.buttonSortByStudentD.UseVisualStyleBackColor = true;
            this.buttonSortByStudentD.Click += new System.EventHandler(this.buttonSortByEmpID_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(553, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(529, 160);
            this.dataGridView2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Student List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(550, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Student in the selected group";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddGroup);
            this.groupBox2.Controls.Add(this.txtGroupName);
            this.groupBox2.Controls.Add(this.txtGroupID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(850, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 138);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Group Details";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroup.Location = new System.Drawing.Point(104, 104);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(105, 23);
            this.btnAddGroup.TabIndex = 4;
            this.btnAddGroup.Text = "Add/update";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnUpdateGroup_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(104, 67);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(105, 20);
            this.txtGroupName.TabIndex = 3;
            // 
            // txtGroupID
            // 
            this.txtGroupID.Location = new System.Drawing.Point(104, 33);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(106, 20);
            this.txtGroupID.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Group Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "GroupID";
            // 
            // btnImportCSV
            // 
            this.btnImportCSV.Location = new System.Drawing.Point(850, 459);
            this.btnImportCSV.Name = "btnImportCSV";
            this.btnImportCSV.Size = new System.Drawing.Size(108, 23);
            this.btnImportCSV.TabIndex = 21;
            this.btnImportCSV.Text = "Import CSV";
            this.btnImportCSV.UseVisualStyleBackColor = true;
            this.btnImportCSV.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtGroupIDPrefix
            // 
            this.txtGroupIDPrefix.Location = new System.Drawing.Point(32, 31);
            this.txtGroupIDPrefix.Name = "txtGroupIDPrefix";
            this.txtGroupIDPrefix.Size = new System.Drawing.Size(100, 20);
            this.txtGroupIDPrefix.TabIndex = 22;
            this.txtGroupIDPrefix.Text = "AutoGroup";
            this.txtGroupIDPrefix.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBulkAssign
            // 
            this.btnBulkAssign.Location = new System.Drawing.Point(41, 82);
            this.btnBulkAssign.Name = "btnBulkAssign";
            this.btnBulkAssign.Size = new System.Drawing.Size(75, 23);
            this.btnBulkAssign.TabIndex = 23;
            this.btnBulkAssign.Text = "BulkAssign";
            this.btnBulkAssign.UseVisualStyleBackColor = true;
            this.btnBulkAssign.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Enter
            // 
            this.Enter.Controls.Add(this.btnBulkAssign);
            this.Enter.Controls.Add(this.txtGroupIDPrefix);
            this.Enter.Location = new System.Drawing.Point(564, 342);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(161, 119);
            this.Enter.TabIndex = 24;
            this.Enter.TabStop = false;
            this.Enter.Text = "Enter GroupID prefix";
            // 
            // btnUpdateGroupTable
            // 
            this.btnUpdateGroupTable.Location = new System.Drawing.Point(562, 290);
            this.btnUpdateGroupTable.Name = "btnUpdateGroupTable";
            this.btnUpdateGroupTable.Size = new System.Drawing.Size(120, 23);
            this.btnUpdateGroupTable.TabIndex = 25;
            this.btnUpdateGroupTable.Text = "Update Table";
            this.btnUpdateGroupTable.UseVisualStyleBackColor = true;
            this.btnUpdateGroupTable.Click += new System.EventHandler(this.btnUpdateGroupTable_Click);
            // 
            // cmbDisplayGroup
            // 
            this.cmbDisplayGroup.FormattingEnabled = true;
            this.cmbDisplayGroup.Location = new System.Drawing.Point(561, 263);
            this.cmbDisplayGroup.Name = "cmbDisplayGroup";
            this.cmbDisplayGroup.Size = new System.Drawing.Size(121, 21);
            this.cmbDisplayGroup.TabIndex = 26;
            this.cmbDisplayGroup.SelectedIndexChanged += new System.EventHandler(this.cmbDisplayGroup_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(561, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Display group:";
            // 
            // gBoxSort
            // 
            this.gBoxSort.Controls.Add(this.buttonSortByStudentName);
            this.gBoxSort.Controls.Add(this.buttonSortByStudentD);
            this.gBoxSort.Controls.Add(this.btnSerialize);
            this.gBoxSort.Controls.Add(this.btnDeSerialize);
            this.gBoxSort.Location = new System.Drawing.Point(363, 212);
            this.gBoxSort.Name = "gBoxSort";
            this.gBoxSort.Size = new System.Drawing.Size(134, 270);
            this.gBoxSort.TabIndex = 28;
            this.gBoxSort.TabStop = false;
            this.gBoxSort.Text = "Sort Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 459);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gBoxSort);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbDisplayGroup);
            this.Controls.Add(this.btnUpdateGroupTable);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.btnImportCSV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gBoxStudentDetails);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "EmployeeDepartmentApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBoxStudentDetails.ResumeLayout(false);
            this.gBoxStudentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Enter.ResumeLayout(false);
            this.Enter.PerformLayout();
            this.gBoxSort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeSerialize;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.GroupBox gBoxStudentDetails;
        private System.Windows.Forms.CheckBox checkBoxFulltime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentFName;
        private System.Windows.Forms.Label lblStudentFName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button buttonSortByStudentName;
        private System.Windows.Forms.Button buttonSortByStudentD;
        private System.Windows.Forms.Label lblStudentLastName;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmbBoxGroupID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.TextBox txtGroupID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnImportCSV;
        private System.Windows.Forms.TextBox txtGroupIDPrefix;
        private System.Windows.Forms.Button btnBulkAssign;
        private System.Windows.Forms.GroupBox Enter;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.TextBox txtStudentLName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblGroupID;
        private System.Windows.Forms.Button btnUpdateGroupTable;
        private System.Windows.Forms.ComboBox cmbDisplayGroup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gBoxSort;
        private System.Windows.Forms.Button button1;

        public System.EventHandler checkBoxFulltime_CheckedChanged { get; set; }
    }
}


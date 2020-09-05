﻿namespace TimeTable_App.Forms.SubForms
{
    partial class StuStatisticsSubForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuStatisticsSubForm));
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCaption = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.gridStudentGroupDetails = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGrpID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gridSubGroupDetails = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPro = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudentGroupDetails)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubGroupDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(373, 79);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaption.Location = new System.Drawing.Point(381, 11);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(203, 30);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.Text = "Student Statistics";
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(60, 79);
            this.txtStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.PlaceholderText = "Group Id...";
            this.txtStudent.Size = new System.Drawing.Size(307, 23);
            this.txtStudent.TabIndex = 1;
            // 
            // gridStudentGroupDetails
            // 
            this.gridStudentGroupDetails.AllowUserToAddRows = false;
            this.gridStudentGroupDetails.AllowUserToDeleteRows = false;
            this.gridStudentGroupDetails.AllowUserToResizeColumns = false;
            this.gridStudentGroupDetails.AllowUserToResizeRows = false;
            this.gridStudentGroupDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStudentGroupDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudentGroupDetails.Location = new System.Drawing.Point(60, 270);
            this.gridStudentGroupDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridStudentGroupDetails.Name = "gridStudentGroupDetails";
            this.gridStudentGroupDetails.ReadOnly = true;
            this.gridStudentGroupDetails.RowHeadersWidth = 51;
            this.gridStudentGroupDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStudentGroupDetails.Size = new System.Drawing.Size(808, 141);
            this.gridStudentGroupDetails.TabIndex = 9;
            this.gridStudentGroupDetails.Text = "dataGridView1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblGrpID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.gridSubGroupDetails);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblPro);
            this.panel1.Controls.Add(this.lblSemester);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.lblGroup);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(60, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 332);
            this.panel1.TabIndex = 10;
            // 
            // lblGrpID
            // 
            this.lblGrpID.AutoSize = true;
            this.lblGrpID.Location = new System.Drawing.Point(145, 137);
            this.lblGrpID.Name = "lblGrpID";
            this.lblGrpID.Size = new System.Drawing.Size(70, 15);
            this.lblGrpID.TabIndex = 0;
            this.lblGrpID.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 137);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Group ID";
            // 
            // gridSubGroupDetails
            // 
            this.gridSubGroupDetails.AllowUserToAddRows = false;
            this.gridSubGroupDetails.AllowUserToDeleteRows = false;
            this.gridSubGroupDetails.AllowUserToResizeColumns = false;
            this.gridSubGroupDetails.AllowUserToResizeRows = false;
            this.gridSubGroupDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSubGroupDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSubGroupDetails.Location = new System.Drawing.Point(0, 183);
            this.gridSubGroupDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridSubGroupDetails.Name = "gridSubGroupDetails";
            this.gridSubGroupDetails.ReadOnly = true;
            this.gridSubGroupDetails.RowHeadersWidth = 51;
            this.gridSubGroupDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSubGroupDetails.Size = new System.Drawing.Size(808, 141);
            this.gridSubGroupDetails.TabIndex = 9;
            this.gridSubGroupDetails.Text = "dataGridView1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(369, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sub Groups";
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.Location = new System.Drawing.Point(145, 91);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(45, 15);
            this.lblPro.TabIndex = 0;
            this.lblPro.Text = "Faculty";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(145, 67);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(85, 15);
            this.lblSemester.TabIndex = 0;
            this.lblSemester.Text = "Lecturer Name";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(145, 42);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(64, 15);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Lecturer ID";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(145, 115);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(70, 15);
            this.lblGroup.TabIndex = 0;
            this.lblGroup.Text = "Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(55, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Group Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 114);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Programme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year";
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(835, 78);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 22);
            this.btnBack.TabIndex = 11;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StuStatisticsSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridStudentGroupDetails);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StuStatisticsSubForm";
            this.Size = new System.Drawing.Size(890, 450);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudentGroupDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubGroupDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.DataGridView gridStudentGroupDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.DataGridView gridSubGroupDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGrpID;
        private System.Windows.Forms.Label label6;
    }
}
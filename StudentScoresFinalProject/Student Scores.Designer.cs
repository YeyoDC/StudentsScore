namespace StudentScoresFinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstStudents = new ListBox();
            label1 = new Label();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblOutputTotal = new Label();
            lblOutputCount = new Label();
            lblOutputAverage = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 20;
            lstStudents.Location = new Point(44, 60);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(357, 104);
            lstStudents.TabIndex = 0;
            lstStudents.SelectedIndexChanged += lstStudents_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 27);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Students";
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(445, 60);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 29);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(445, 96);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(445, 132);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblOutputTotal
            // 
            lblOutputTotal.BorderStyle = BorderStyle.Fixed3D;
            lblOutputTotal.Location = new Point(339, 187);
            lblOutputTotal.Name = "lblOutputTotal";
            lblOutputTotal.Size = new Size(62, 25);
            lblOutputTotal.TabIndex = 5;
            // 
            // lblOutputCount
            // 
            lblOutputCount.BorderStyle = BorderStyle.Fixed3D;
            lblOutputCount.Location = new Point(339, 212);
            lblOutputCount.Name = "lblOutputCount";
            lblOutputCount.Size = new Size(62, 25);
            lblOutputCount.TabIndex = 6;
            // 
            // lblOutputAverage
            // 
            lblOutputAverage.BorderStyle = BorderStyle.Fixed3D;
            lblOutputAverage.Location = new Point(339, 237);
            lblOutputAverage.Name = "lblOutputAverage";
            lblOutputAverage.Size = new Size(62, 25);
            lblOutputAverage.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(236, 192);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 8;
            label5.Text = "Score Total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(232, 217);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 9;
            label6.Text = "Score count:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(255, 242);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 10;
            label7.Text = "Average:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(445, 233);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 309);
            Controls.Add(btnExit);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblOutputAverage);
            Controls.Add(lblOutputCount);
            Controls.Add(lblOutputTotal);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(label1);
            Controls.Add(lstStudents);
            Name = "Form1";
            Text = "Student Scores";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstStudents;
        private Label label1;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblOutputTotal;
        private Label lblOutputCount;
        private Label lblOutputAverage;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnExit;
    }
}
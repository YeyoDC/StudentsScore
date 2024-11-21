namespace StudentScoresFinalProject
{
    partial class Add_New_Student
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
            txtName = new TextBox();
            txtScore = new TextBox();
            btnAddScore = new Button();
            label1 = new Label();
            label2 = new Label();
            btnClearScores = new Button();
            btnCancel = new Button();
            btnOkay = new Button();
            label3 = new Label();
            lblOutputScores = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(93, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(252, 27);
            txtName.TabIndex = 0;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(93, 87);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(125, 27);
            txtScore.TabIndex = 1;
            // 
            // btnAddScore
            // 
            btnAddScore.Location = new Point(239, 85);
            btnAddScore.Name = "btnAddScore";
            btnAddScore.Size = new Size(106, 29);
            btnAddScore.TabIndex = 2;
            btnAddScore.Text = "Add Score";
            btnAddScore.UseVisualStyleBackColor = true;
            btnAddScore.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 39);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 94);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Score:";
            // 
            // btnClearScores
            // 
            btnClearScores.Location = new Point(239, 201);
            btnClearScores.Name = "btnClearScores";
            btnClearScores.Size = new Size(106, 31);
            btnClearScores.TabIndex = 5;
            btnClearScores.Text = "Clear Scores";
            btnClearScores.UseVisualStyleBackColor = true;
            btnClearScores.Click += btnClearScores_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(239, 251);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 31);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOkay
            // 
            btnOkay.Location = new Point(112, 251);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(106, 31);
            btnOkay.TabIndex = 7;
            btnOkay.Text = "Ok";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 131);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 8;
            label3.Text = "Scores:";
            // 
            // lblOutputScores
            // 
            lblOutputScores.BorderStyle = BorderStyle.Fixed3D;
            lblOutputScores.Location = new Point(96, 131);
            lblOutputScores.Name = "lblOutputScores";
            lblOutputScores.Size = new Size(249, 25);
            lblOutputScores.TabIndex = 9;
            // 
            // Add_New_Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 302);
            Controls.Add(lblOutputScores);
            Controls.Add(label3);
            Controls.Add(btnOkay);
            Controls.Add(btnCancel);
            Controls.Add(btnClearScores);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddScore);
            Controls.Add(txtScore);
            Controls.Add(txtName);
            Name = "Add_New_Student";
            Text = "Add_New_Student";
            Load += Add_New_Student_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtScore;
        private Button btnAddScore;
        private Label label1;
        private Label label2;
        private Button btnClearScores;
        private Button btnCancel;
        private Button btnOkay;
        private Label label3;
        private Label lblOutputScores;
    }
}
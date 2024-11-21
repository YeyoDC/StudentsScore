namespace StudentScoresFinalProject
{
    partial class Update_Student_Scores
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
            label1 = new Label();
            lblOutputName = new Label();
            label3 = new Label();
            lstboxScores = new ListBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnClearScores = new Button();
            btnOkay = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 73);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // lblOutputName
            // 
            lblOutputName.BorderStyle = BorderStyle.Fixed3D;
            lblOutputName.Location = new Point(138, 66);
            lblOutputName.Name = "lblOutputName";
            lblOutputName.Size = new Size(278, 26);
            lblOutputName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 125);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Scores:";
            // 
            // lstboxScores
            // 
            lstboxScores.FormattingEnabled = true;
            lstboxScores.ItemHeight = 20;
            lstboxScores.Location = new Point(138, 125);
            lstboxScores.Name = "lstboxScores";
            lstboxScores.Size = new Size(150, 184);
            lstboxScores.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(322, 125);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(322, 178);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(322, 229);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(102, 29);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClearScores
            // 
            btnClearScores.Location = new Point(322, 280);
            btnClearScores.Name = "btnClearScores";
            btnClearScores.Size = new Size(102, 29);
            btnClearScores.TabIndex = 7;
            btnClearScores.Text = "Clear Scores";
            btnClearScores.UseVisualStyleBackColor = true;
            btnClearScores.Click += btnClearScores_Click;
            // 
            // btnOkay
            // 
            btnOkay.Location = new Point(186, 345);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(102, 29);
            btnOkay.TabIndex = 8;
            btnOkay.Text = "OK";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(322, 345);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Update_Student_Scores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 418);
            Controls.Add(btnCancel);
            Controls.Add(btnOkay);
            Controls.Add(btnClearScores);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lstboxScores);
            Controls.Add(label3);
            Controls.Add(lblOutputName);
            Controls.Add(label1);
            Name = "Update_Student_Scores";
            Text = "Update_Student_Scores";
            Load += Update_Student_Scores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblOutputName;
        private Label label3;
        private ListBox lstboxScores;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnClearScores;
        private Button btnOkay;
        private Button btnCancel;
    }
}
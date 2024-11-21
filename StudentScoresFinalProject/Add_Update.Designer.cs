namespace StudentScoresFinalProject
{
    partial class Add_Update
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
            txtScore = new TextBox();
            btnAdd_Update = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 60);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Score:";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(135, 60);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(125, 27);
            txtScore.TabIndex = 1;
            // 
            // btnAdd_Update
            // 
            btnAdd_Update.Location = new Point(32, 115);
            btnAdd_Update.Name = "btnAdd_Update";
            btnAdd_Update.Size = new Size(94, 29);
            btnAdd_Update.TabIndex = 2;
            btnAdd_Update.Text = "Add_Update";
            btnAdd_Update.UseVisualStyleBackColor = true;
            btnAdd_Update.Click += btnAdd_Update_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(166, 115);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Add_Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 185);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd_Update);
            Controls.Add(txtScore);
            Controls.Add(label1);
            Name = "Add_Update";
            Text = "Form2";
            Load += Add_Update_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtScore;
        private Button btnAdd_Update;
        private Button btnCancel;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace StudentScoresFinalProject
{
    public partial class Add_New_Student : Form
    {
        // local instance of the student object
        Student student = new Student();
        // list that will exist whenever this form is open
        List<int> scores = new List<int>();
        public Add_New_Student()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // here we will populate the list of grade for the student\

          // we will start with the validator
            if (Validator.IsPresent(txtScore) && Validator.IsInteger(txtScore) && Validator.IsWithinRange(txtScore))
            {
                int score = int.Parse(txtScore.Text);
                scores.Add(score);
                lblOutputScores.Text += " " + score;
            }
          

        }

        private void Add_New_Student_Load(object sender, EventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
          
            if (Validator.IsPresent(txtName))
            {
                // we are saving the name by first spliting by any blank space, then assigning it to the properties of the student object
                string[] fullName = txtName.Text.Split(" ");
                student.FirstName = fullName[0];
                student.LastName = fullName[1];
                // assigning the temporary list into the property value
                student.Grade = scores;
                // then we will save all the grades added into the student
                this.Tag = student;
                // once we save the student, this window will be closed.
                this.Close();
            }
            
           


        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            // emptying the label when clearing scores
            lblOutputScores.Text = string.Empty;
            // cleariing the list of items
            scores.Clear();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

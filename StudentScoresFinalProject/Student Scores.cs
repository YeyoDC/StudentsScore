using System.Dynamic;
using System;
using Business_Layer;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace StudentScoresFinalProject
{
    public partial class Form1 : Form
    {
        StudentList student = new StudentList();

        // variable to use for the clone

        Student studentEdit = new();



        public Form1()
        {
            InitializeComponent();
            // wire the method to show in the list
            student.changed += new StudentList.ChangeHandler(DisplayStudents);

        }
        public void DisplayStudents(StudentList student)
        {
            lstStudents.Items.Clear();
            for (int i = 0; i < student.count; i++)
            { // loop thtough all the students in the list 
                if (student[i] is not null)
                {
                    // this part will add a pipe before each grade, and will save it into a variable
                    string grades = null;
                    if (student[i].Grade is not null)
                    {
                        for (int x = 0; x < student[i].Grade.Count; x++)
                        {
                            grades += " | " + student[i].Grade[x];
                        }
                    }

                    var item = student[i].ToString() + grades;
                    if (item is not null)
                    {
                        lstStudents.Items.Add(item);
                    }
                }

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //hard-coded values

            student.Add("Diego", "Cuellar", new List<int> { 100, 89, 90, 100 });
            student.Add("Gustavo", "Aldama", new List<int> { 95, 50, 100 });
            student.Add("Sam", "Smith", new List<int> { 85, 89, 90 });
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex != -1)
            {
                if (student[lstStudents.SelectedIndex].Grade.Count > 0)
                {
                    // calling the method total for the specified object in the index
                    lblOutputTotal.Text = student[lstStudents.SelectedIndex].ScoreTotal().ToString();
                    lblOutputCount.Text = student[lstStudents.SelectedIndex].ScoreCount().ToString();
                    lblOutputAverage.Text = student[lstStudents.SelectedIndex].ScoreAverage().ToString("F");
                }
                else
                {
                    lblOutputTotal.Text = "0";
                    lblOutputCount.Text = "0";
                    lblOutputAverage.Text = "0";

                }

              
            }
            else
            {
                // if nothing is selected, the labels will be emptied
                lblOutputAverage.Text = "";
                lblOutputCount.Text = "";
                lblOutputTotal.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creating an isntance of the form
            Add_New_Student addNewStudent = new Add_New_Student();
            // this opens the form
            addNewStudent.ShowDialog();
            // this will bring the student we added from 

            Student stu = addNewStudent.Tag as Student;
            if (stu != null)
            {
                student.Add(stu);
            }



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex != -1)
            {
                // implementing a clone of the object 
                studentEdit = (Student)student[lstStudents.SelectedIndex].Clone();
                int index = lstStudents.SelectedIndex;

                // showing the update students scores
                Update_Student_Scores updateScores = new Update_Student_Scores();
                updateScores.Tag = studentEdit;
                updateScores.ShowDialog();


                //updating the new information 
                // here is where the clone will be merged

                // removing the record first 
                studentEdit = updateScores.Tag as Student;

                // we are commiting the changes by saving it into the current object at the current index
                student[index] = studentEdit;
                // if after editing, there is not grades anymore, we will remove from the labels
                if (student[index].Grade.Count <= 0)
                {
                    lblOutputAverage.Text = "";
                    lblOutputCount.Text = "";
                    lblOutputTotal.Text = "";
                }
                else
                {
                    lblOutputTotal.Text = student[index].ScoreTotal().ToString();
                    lblOutputCount.Text = student[index].ScoreCount().ToString();
                    lblOutputAverage.Text = student[index].ScoreAverage().ToString("F");
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update");
            }
           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstStudents.SelectedIndex != -1)
            {
                student.Remove(student[lstStudents.SelectedIndex]);
                lblOutputAverage.Text = "";
                lblOutputCount.Text = "";
                lblOutputTotal.Text = "";
            }
            else
            {
                MessageBox.Show("Please select a student to remove");
            }
          
        }
    }
}
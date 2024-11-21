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
    public partial class Update_Student_Scores : Form
    {
        Student student = new Student();
        public Update_Student_Scores()
        {
            InitializeComponent();

        }

        private void Update_Student_Scores_Load(object sender, EventArgs e)
        {
            student = this.Tag as Student;

            // we will load the selected item 


            // setting the values in the label and list
            lblOutputName.Text = student.ToString();
            //setting the grades in the listbox
            for (int i = 0; i < student.Grade.Count; i++)
            {
                lstboxScores.Items.Add(student.Grade[i].ToString());
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // opening the new form
            Add_Update addScore = new Add_Update();
            addScore.Text = "Add New Score";
            addScore.ShowDialog();

            // adding new value to the list
            if(addScore.Tag != null)
            {
                lstboxScores.Items.Add(addScore.Tag);
            }
           

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // this if statement makes sure user is selecting an item on the listbox
            if (lstboxScores.SelectedIndex >= 0)
            {
                // getting the object's grade 
                Add_Update addScore = new Add_Update();

                addScore.Text = "Update";
                // saving the current object item to the Tag of the new form
                addScore.Tag = lstboxScores.SelectedItem;
                addScore.ShowDialog();

                // updating current value 
                // saving index value to delet and insert the grades at the specific location on the listbox
                int index = lstboxScores.SelectedIndex;
                // making sure the Tag property is not empty so we can update the information
                if (addScore.Tag != null)
                {
                    lstboxScores.Items.RemoveAt(index);
                    lstboxScores.Items.Insert(index, addScore.Tag);
                }
            }
            else
            // if user is not selecting any grade on the listbox will show this message
            {
                MessageBox.Show("Please selecte grade to update");
            }



        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //if statement to make sure user is selecting an item from the listbox to remove
            if (lstboxScores.SelectedIndex >= 0)
            {
                // remove item at the indicated index
                int index = lstboxScores.SelectedIndex;
                lstboxScores.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Please select a grade to remove");
            }

        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            // clearing all the grades from the listbox
            lstboxScores.Items.Clear();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            // new list to replaced in the properties 
            List<int> grades = new List<int>();

            // loop to get all the values from the listbox
            for (int i = 0; i < lstboxScores.Items.Count; i++)
            {
                // here we will populate our new list of grades of Int type
                grades.Add(int.Parse(lstboxScores.Items[i].ToString()));

            }
            // we will declare student Grade property to null to add the new grades
            student.Grade = null;
            // then we will save the new value for the grade property 
            student.Grade = grades;


            // we will close the form and go back to the main one. 

            this.Tag = student;
            // this the Tag still holds the object but with the new information, we just need to call it back on the main form
            this.Close();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

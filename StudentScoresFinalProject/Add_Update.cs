using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace StudentScoresFinalProject
{
    public partial class Add_Update : Form
    {
        public Add_Update()
        {
            InitializeComponent();
        }

        private void Add_Update_Load(object sender, EventArgs e)
        {
            // verifies if the tag comes with an object or null

            // if tag is not null, it means we passed along a grade to be modified 
            if (this.Tag is not null)
            {
                // if the Tag does not come null it means a value needs to be modified, therefore the button will say Update
                btnAdd_Update.Text = "Update";
                txtScore.Text = this.Tag.ToString();
            }
            // if tag comes null, it means we want to add a new grade
            else
            {
                btnAdd_Update.Text = "Add";
                txtScore.Text = string.Empty;

            }


        }

        private void btnAdd_Update_Click(object sender, EventArgs e)
        {
            // save the new value
            // we will first make sure the tag is null again to save the new value
            if (Validator.IsPresent(txtScore) && Validator.IsInteger(txtScore) && Validator.IsWithinRange(txtScore))
            {
                // making the Tag Null to save new value into the property
                this.Tag = null;
                // saving new value into it
                this.Tag = txtScore.Text;
                this.Close();
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

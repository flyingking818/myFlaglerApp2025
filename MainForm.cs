﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFlaglerApp2025
{
    public partial class MainForm : Form
    {
        //Variable declarations:
        private string selectedImagePath="";


        public MainForm()
        {
            InitializeComponent();
            InitializeDataGridView();

            //Intitialize the person radio buttons
            rdoProfessor.CheckedChanged += PersonTypeChanged;
            rdoStudent.CheckedChanged += PersonTypeChanged;
            rdoStaff.CheckedChanged += PersonTypeChanged;
        }

        private void InitializeDataGridView()
        {
            dgvPeople.Columns.Clear();
            dgvPeople.Columns.Add("Type", "Person Type");
            dgvPeople.Columns.Add("Name", "Name");
            dgvPeople.Columns.Add("ID", "ID");
            dgvPeople.Columns.Add("Details", "Details");
        }

        private void PersonTypeChanged (object sender, EventArgs e)
        {
            //Show the group based on the user's selection
            grpProfessor.Visible = rdoProfessor.Checked;
            grpStudent.Visible = rdoStudent.Checked;
            grpStaff.Visible = rdoStaff.Checked;

            //alternative use the if statement
            /*
            if (rdoProfessor.Checked)
            {
                grpProfessor.Visible = true;
            }
            */

        }


        private void btnDisplayProfile_Click(object sender, EventArgs e)
        {
            //Validate user inputs, using early exit
            if (!ValidateInput()) return;

            //In case of run time error, let's check for any exceptions.
            try
            {

                //Polymorphism: The Person variable can hold any subclass instance.
                //The CreatePerson() method acts like a factory,
                //creating the appropriate derived class based on some condition(radio button selection).
                Person person = CreatePerson();  //create a person object on demand!

                if (person == null) return;  //early exit if a lot of processes happen after this.
                
                lblResult.Text = person.GetDetails();

            }
            catch (Exception ex)
            {

               MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private Person CreatePerson()
        {
            Person person = null;
            if (rdoProfessor.Checked)
            {
                person = new Professor
                {
                    Name = txtName.Text,
                    ID = txtID.Text,
                    Email = txtEmail.Text,
                    Department = cmbDepartment.Text,
                    ResearchArea = txtResearchArea.Text,
                    IsTerminalDegree = chkTerminalDegree.Checked,
                };      
            }
            else if (rdoStudent.Checked)
            {
                person = new Student
                {
                    Name = txtName.Text,
                    ID = txtID.Text,
                    Email = txtEmail.Text,
                    Major = cmdMajor.Text,
                    GPA = double.Parse(txtGPA.Text), //this is safe because we already did the validation.
                    IsFullTime = chkFullTime.Checked,
                    EnrollmentDate = Convert.ToDateTime(dtpEnrollmentDate.Text)
                };
            }
            else if (rdoStaff.Checked)
            {
                person = new Staff
                {
                    Name = txtName.Text,
                    ID = txtID.Text,
                    Email = txtEmail.Text,
                    Position = txtPosition.Text,                    
                    Division = txtDivision.Text,
                    IsAdministrative = chkAdministrative.Checked
                };
            }

            return person;

        }


        private bool ValidateInput() { 
            if(string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Focus();
                return ShowError("Name is required!");
            }
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Focus();
                return ShowError("ID is required!");
            }
            if (rdoStudent.Checked && !double.TryParse(txtGPA.Text, out double gpa))
            {
                txtGPA.Focus();
                return ShowError("Invalid GPA Please enter a valid number!");
            }



            return true;
        }

        private bool ShowError(string message) {
            MessageBox.Show(message,"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog()) {
                ofd.Filter = "Image Files|*.jpg;*.png;*.gif;*.jpeg";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    picProfile.Image = Image.FromFile(selectedImagePath);
                    picProfile.SizeMode = PictureBoxSizeMode.Zoom;
                }            
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFlaglerApp2025
{
    public partial class MainForm : BaseForm
    {
        //Variable declarations:
        private string selectedImagePath="";

        private List<Person> people = new List<Person>();

        public MainForm()
        {
            InitializeComponent();
            InitializeDataGridView();

            //Intitialize the person radio buttons
            rdoProfessor.CheckedChanged += PersonTypeChanged;
            rdoStudent.CheckedChanged += PersonTypeChanged;
            rdoStaff.CheckedChanged += PersonTypeChanged;

            //Our own connections (this alternative is better)
            // txtName.MouseHover += txtName_MouseHover;
        }

        private void InitializeDataGridView()
        {
            dgvPeople.Columns.Clear();
            dgvPeople.Columns.Add("Type", "Person Type");
            dgvPeople.Columns.Add("Name", "Name");
            dgvPeople.Columns.Add("ID", "ID");
            dgvPeople.Columns.Add("Details", "Details");

            //don't forget to add the image column
            var imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "Image";  //ID
            imageColumn.HeaderText = "Profile Image"; //Display text 
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; //Scales automatically
            dgvPeople.Columns.Add(imageColumn);

            //Set the widths of the columns based on the data fields.
            dgvPeople.Columns["Type"].Width = 220;
            dgvPeople.Columns["Name"].Width = 300;
            dgvPeople.Columns["ID"].Width = 200;
            dgvPeople.Columns["Details"].Width = 800;
            dgvPeople.Columns["Details"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvPeople.Columns["Image"].Width = 300;

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
            if (!ValidateInput()) return;

            try
            {
                Person person = CreatePerson();
                if (person == null) return;

                //Set the image to the Image property, convert the physical image into bytes[]
                if (!string.IsNullOrEmpty(selectedImagePath)) { 
                    person.ProfileImage = File.ReadAllBytes(selectedImagePath);
                }

                //Add the person object into the people list
                people.Add(person);

                //Display the people in the data view grid (table)
                UpdateDisplay();

                //ClearForm;

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void UpdateDisplay()
        {
            dgvPeople.Rows.Clear(); // Clear existing rows

            foreach (var person in people)
            {
                // Create a new row
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvPeople);

                // Populate the row with data
                row.Cells[0].Value = person.GetType().Name; // Type (Student, Professor, Staff)
                row.Cells[1].Value = person.Name; // Name
                row.Cells[2].Value = person.ID; // ID
                row.Cells[3].Value = person.GetDetails(); // Details

                // Handle the image column
                if (person.ProfileImage != null && person.ProfileImage.Length > 0)
                {
                    // Convert byte[] to Image
                    using (var ms = new MemoryStream(person.ProfileImage))
                    {
                        Image image = Image.FromStream(ms); // Create the Image object
                        row.Cells[4].Value = image; // Assign the Image to the cell
                    }
                }
                else
                {
                    row.Cells[4].Value = null; // No image
                }

                row.Height = 70;

                //Don't forget to add the row the grid
                dgvPeople.Rows.Add(row);
            }

        }

       

        private void txtName_MouseHover(object sender, EventArgs e)
        {
            txtName.BackColor = Color.Yellow;
        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
        }

        private void txtName_Enter(object sender, EventArgs e)  //it captures both mouse click in and tab in.
        {
            lblResult.Text = "";
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            //Close the current form
            this.Hide();

            //Instantiate the secondary form
            // ProfileDetailForm frmDetail = new ProfileDetailForm(personObj); pass the person obj to the secondary form
            ProfileDetailForm frmDetail = new ProfileDetailForm();

            //Show the new form
            frmDetail.Show();

        }
    }
}

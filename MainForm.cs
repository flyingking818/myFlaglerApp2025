using System;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDisplayProfile_Click(object sender, EventArgs e)
        {
            //Validate user inputs
            if (!ValidateInput()) return;
        }

        private bool ValidateInput() { 
            if(string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Focus();
                return ShowError("Name is required!");
            }

            return true;
        }

        private bool ShowError(string message) {
            MessageBox.Show(message,"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }



    }
}

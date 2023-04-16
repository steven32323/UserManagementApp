using MyApp.Services.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyApp.Models;


namespace MyApp.WinForm
{
    public partial class AddUser : Form
    {
        private readonly IServiceFactory _serviceFactory;

        public AddUser(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate all controls on the form
            if (!ValidateChildren())
            {
                // If any validation has failed, do not save the user
                return;
            }
            // Read input values from input fields
            string forename = inputForename.Text;
            string surname = inputSurname.Text;
            bool isActive = isActiveChecked.Checked;
            DateTime dateOfBirth = inputDoB.Value;

            // Create a new User object
            User newUser = new User
            {
                Forename = forename,
                Surname = surname,
                IsActive = isActive,
                DateOfBirth = dateOfBirth
            };

            // Save the new user using the UserService
            _serviceFactory.UserService.Create(newUser);

            // Close the form and return a DialogResult of OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void inputForename_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputForename.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(inputForename, "Forename is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(inputForename, string.Empty);
            }
        }

        private void inputSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputSurname.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(inputSurname, "Surname is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(inputSurname, string.Empty);
            }
        }

        private void inputDoB_Validating(object sender, CancelEventArgs e)
        {
            if (inputDoB.Value.Date > DateTime.Today)
            {
                e.Cancel = true;
                errorProvider.SetError(inputDoB, "Date of birth cannot be in the future.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(inputDoB, string.Empty);
            }
        }
    }
}

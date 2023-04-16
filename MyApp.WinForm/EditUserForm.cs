using MyApp.Services.Factories.Implementations;
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
    public partial class EditUserForm : Form
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly int _userId;
        private User _userToEdit;

        public EditUserForm(IServiceFactory serviceFactory, int userId)
        {
            _serviceFactory = serviceFactory;
            _userId = userId;
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _userToEdit = _serviceFactory.UserService.GetById(_userId);
            inputForename.Text = _userToEdit.Forename;
            inputSurname.Text = _userToEdit.Surname;
            isActive.Checked = _userToEdit.IsActive;
            inputDoB.Value = _userToEdit.DateOfBirth;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrEmpty(inputForename.Text) || string.IsNullOrEmpty(inputSurname.Text))
            {
                MessageBox.Show("Forename and Surname fields cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (inputDoB.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Date of Birth cannot be set in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update user data
            _userToEdit.Forename = inputForename.Text;
            _userToEdit.Surname = inputSurname.Text;
            _userToEdit.IsActive = isActive.Checked;
            _userToEdit.DateOfBirth = inputDoB.Value;

            // Save changes to the database
            _serviceFactory.UserService.Update(_userToEdit);

            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

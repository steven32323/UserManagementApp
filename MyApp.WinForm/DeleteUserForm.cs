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
using MyApp.Services.Factories.Interfaces;

namespace MyApp.WinForm
{
    public partial class DeleteUserForm : Form
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly User _userToDelete;

        public DeleteUserForm(IServiceFactory serviceFactory, User userToDelete)
        {
            _serviceFactory = serviceFactory;
            _userToDelete = userToDelete;
            InitializeComponent();
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            _serviceFactory.UserService.Delete(_userToDelete);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

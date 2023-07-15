using eventManagement.Model;
using eventManagement.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventManagement.WinUI.Users
{
    public partial class frmUserDetails : Form
    {
        private readonly APIService _service = new APIService("users");
        private readonly APIService _rolesService = new APIService("roles");

        private int? _id = null;
        public frmUserDetails(int? userId = null)
        {
            InitializeComponent();
            _id = userId;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var roles = chxRolesList.CheckedItems.Cast<Role>().Select(x => x.RoleId).ToList();
            if (ValidateChildren())
            {
                var request = new UserInsertRequest()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPasswordConfirmation.Text,
                    Active = chxActive.Checked,
                    Roles = roles,
                };

                if (_id.HasValue)
                {
                    await _service.Update<User>(_id.Value, request);
                    MessageBox.Show(Properties.Resources.Success_Update);
                }
                else
                {
                    await _service.Insert<User>(request);
                    MessageBox.Show(Properties.Resources.Success_Insert);
                }
                this.Close();
            }
        }

        private async void frmUserDetails_Load(object sender, EventArgs e)
        {
            await LoadRoles();
            if (_id.HasValue)
            {
                var user = await _service.GetById<User>(_id);
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtEmail.Text = user.Email;
                txtUsername.Text = user.Username;
                chxActive.Checked = user.Active;
                var userRoles = user.UserRoles.ToArray();

                for (int i = 0; i < chxRolesList.Items.Count; i++)
                {
                    for (int j = 0; j < user.UserRoles.Count; j++)
                    {
                        var roleItem = userRoles[j];
                        Role role = (Role)chxRolesList.Items[i];

                        if (role.Name == roleItem.Role.Name)
                        {
                            chxRolesList.SetItemCheckState(i, CheckState.Checked);
                        }
                    }
                }
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider.SetError(txtFirstName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            } else if (txtFirstName.Text.Length < 2 || txtFirstName.Text.Length > 50)
            {
                errorProvider.SetError(txtFirstName, Properties.Resources.Validation_Min2Max50);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtFirstName, null);
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider.SetError(txtLastName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtLastName.Text.Length < 2 || txtLastName.Text.Length > 50)
            {
                errorProvider.SetError(txtLastName, Properties.Resources.Validation_Min2Max50);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtLastName, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtEmail.Text.Length < 3 || txtEmail.Text.Length > 100)
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_Min3Max100);
                e.Cancel = true;
            } else if (!regex.Match(txtEmail.Text).Success)
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_EmailInvalid);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtUsername.Text.Length < 2 || txtUsername.Text.Length > 20)
            {
                errorProvider.SetError(txtUsername, Properties.Resources.Validation_Min2Max20);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtPassword.Text.Length < 2 || txtPassword.Text.Length > 20)
            {
                errorProvider.SetError(txtPassword, Properties.Resources.Validation_Min2Max20);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPassword, null);
            }
        }

        private void txtPasswordConfirmation_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPasswordConfirmation.Text))
            {
                errorProvider.SetError(txtPasswordConfirmation, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtPassword.Text != txtPasswordConfirmation.Text)
            {
                errorProvider.SetError(txtPasswordConfirmation, Properties.Resources.Validation_PasswordMatch);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPasswordConfirmation, null);
            }
        }

        private void frmUserDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private async Task<bool> LoadRoles()
        {
            var roles = await _rolesService.Get<List<Role>>();

            chxRolesList.DataSource = roles;
            chxRolesList.DisplayMember = "Name";
            chxRolesList.ValueMember = "RoleId";
            return true;
        }
    }
}

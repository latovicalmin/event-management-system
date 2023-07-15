using eventManagement.Model;
using eventManagement.Model.Requests;
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

namespace eventManagement.WinUI.Organizations
{
    public partial class frmOrganizationDetails : Form
    {

        private readonly APIService _apiOrganizations = new APIService("organizations");
        OrganizationUpsertRequest request = new OrganizationUpsertRequest();
        private int? _id = null;
        private bool _formValid = false;
        private bool _imageChanged = false;
        private Organization _organization = null;

        public frmOrganizationDetails(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            request.Name = txtName.Text;

            txtName_Validating_1(null, null);
            if (_formValid)
            {
                if (_id.HasValue)
                {
                    if (!_imageChanged)
                    {
                        request.Logo = _organization.Logo;
                    }
                    await _apiOrganizations.Update<Organization>(_id.Value, request);
                    MessageBox.Show(Properties.Resources.Success_Update);
                }
                else
                {
                    await _apiOrganizations.Insert<Organization>(request);
                    MessageBox.Show(Properties.Resources.Success_Insert);
                }
                this.Close();
            }
        }

        private void txtName_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, Properties.Resources.Validation_RequiredField);
                _formValid = false;
            }
            else if (txtName.Text.Length < 2 || txtName.Text.Length > 50)
            {
                errorProvider.SetError(txtName, Properties.Resources.Validation_Min2Max50);
                _formValid = false;
            }
            else
            {
                errorProvider.SetError(txtName, null);
                _formValid = true;
            }
        }

        private async void frmOrganizationDetails_Load_1(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var eventObj = await _apiOrganizations.GetById<Organization>(_id);
                _organization = eventObj;

                txtName.Text = eventObj.Name;

                if (eventObj.Logo != null && eventObj.Logo.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(eventObj.Logo);
                    Image image = Image.FromStream(ms);
                    pictureBox.Image = image;
                }
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);
                request.Logo = file;
                txtLogo.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox.Image = image;
                _imageChanged = true;
            }
        }
    }
}

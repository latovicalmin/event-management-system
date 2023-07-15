using eventManagement.Model;
using eventManagement.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventManagement.WinUI.Categories
{
    public partial class frmCategoryDetails : Form
    {
        private readonly APIService _apiCategories = new APIService("categories");
        private int? _id = null;
        private bool _formValid = false;

        public frmCategoryDetails(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            CategoryUpsertRequest request = new CategoryUpsertRequest()
            {
                Name = txtName.Text,
            };

            txtName_Validating(null, null);
            if (_formValid)
            {
                if (_id.HasValue)
                {
                    await _apiCategories.Update<Category>(_id.Value, request);
                    MessageBox.Show(Properties.Resources.Success_Update);
                }
                else
                {
                    await _apiCategories.Insert<Category>(request);
                    MessageBox.Show(Properties.Resources.Success_Insert);
                }
                this.Close();
            }
        }

        private async void frmCategoryDetails_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var eventObj = await _apiCategories.GetById<Category>(_id);
                txtName.Text = eventObj.Name;
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
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
    }
}

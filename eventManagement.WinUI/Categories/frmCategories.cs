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
    public partial class frmCategories : Form
    {
        private readonly APIService _categoriesService = new APIService("categories");
        public frmCategories()
        {
            InitializeComponent();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            btnSearch_Click_1(null, null);
        }

        private async void btnSearch_Click_1(object sender, EventArgs e)
        {
            var search = new CategorySearchRequest()
            {
                Name = txtCategoryName.Text,
            };

            var result = await _categoriesService.Get<List<Category>>(search);
            dgvEvents.AutoGenerateColumns = false;
            dgvEvents.DataSource = result;
        }

        private void dgvEvents_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            var id = dgvEvents.SelectedRows[0].Cells[0].Value;

            frmCategoryDetails frm = new frmCategoryDetails(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}

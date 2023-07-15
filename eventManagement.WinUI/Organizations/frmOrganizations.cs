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

namespace eventManagement.WinUI.Organizations
{
    public partial class frmOrganizations : Form
    {
        private readonly APIService _organizationService = new APIService("organizations");
        public frmOrganizations()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new OrganizationsSearchRequest()
            {
                Name = txtOrganizationName.Text,
            };

            var result = await _organizationService.Get<List<Organization>>(search);
            dgvEvents.AutoGenerateColumns = false;
            dgvEvents.DataSource = result;
        }

        private void frmOrganizations_Load(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }

        private void dgvEvents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvEvents.SelectedRows[0].Cells[0].Value;

            frmOrganizationDetails frm = new frmOrganizationDetails(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}

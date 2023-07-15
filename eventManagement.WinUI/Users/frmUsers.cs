using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using eventManagement.Model;
using eventManagement.Model.Requests;

namespace eventManagement.WinUI.Users
{
    public partial class frmUsers : Form
    {
        private readonly APIService _apiService = new APIService("users");
        public frmUsers()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new UserSearchRequest()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };

            var result = await _apiService.Get<List<User>>(search);
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = result;
        }

        private void dgvUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvUsers.SelectedRows[0].Cells[0].Value;

            frmUserDetails frm = new frmUserDetails(int.Parse(id.ToString()));
            frm.Show();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }
    }
}

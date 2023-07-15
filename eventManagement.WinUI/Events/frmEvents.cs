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

namespace eventManagement.WinUI.Events
{
    public partial class frmEvents : Form
    {
        private readonly APIService _apiService = new APIService("events");
        public frmEvents()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new EventSearchRequest()
            {
                Name = txtEventName.Text,
            };

            var result = await _apiService.Get<List<Event>>(search);
            dgvEvents.AutoGenerateColumns = false;
            dgvEvents.DataSource = result;
        }

        private void frmEvents_Load(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }

        private void dgvEvents_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            var id = dgvEvents.SelectedRows[0].Cells[0].Value;

            frmEventDetails frm = new frmEventDetails(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}

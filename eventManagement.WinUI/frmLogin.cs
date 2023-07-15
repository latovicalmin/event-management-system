using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventManagement.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("roles");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            try
            {
                APIService.Username = username;
                APIService.Password = password;

                await _service.Get<dynamic>(null);

                frmIndex frm = new frmIndex();
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

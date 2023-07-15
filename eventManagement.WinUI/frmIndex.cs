using eventManagement.WinUI.Categories;
using eventManagement.WinUI.Events;
using eventManagement.WinUI.Organizations;
using eventManagement.WinUI.Reports;
using eventManagement.WinUI.Users;
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
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.MdiParent = this;
            frm.Show();
        }

        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails();
            frm.Show();
        }

        private void pretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEvents frm = new frmEvents();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEventDetails frm = new frmEventDetails();
            frm.Show();
        }

        private void pretragaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmOrganizations frm = new frmOrganizations();
            frm.Show();
        }

        private void pretražiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategories frm = new frmCategories();
            frm.Show();
        }

        private void novaKategorijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoryDetails frm = new frmCategoryDetails();
            frm.Show();
        }

        private void noviDogađajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrganizationDetails frm = new frmOrganizationDetails();
            frm.Show();
        }

        private void izvještajToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void događajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEventsReport frm = new frmEventsReport();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

namespace eventManagement.WinUI
{
    partial class frmIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dogaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.organizacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviDogađajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaKategorijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.događajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.dogaToolStripMenuItem,
            this.organizacijeToolStripMenuItem,
            this.kategorijeToolStripMenuItem,
            this.izvještajToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.noviKorisnikToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorisnikToolStripMenuItem_Click);
            // 
            // dogaToolStripMenuItem
            // 
            this.dogaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem1,
            this.toolStripMenuItem1});
            this.dogaToolStripMenuItem.Name = "dogaToolStripMenuItem";
            this.dogaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.dogaToolStripMenuItem.Text = "Događaji";
            // 
            // pretragaToolStripMenuItem1
            // 
            this.pretragaToolStripMenuItem1.Name = "pretragaToolStripMenuItem1";
            this.pretragaToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.pretragaToolStripMenuItem1.Text = "Pretraga";
            this.pretragaToolStripMenuItem1.Click += new System.EventHandler(this.pretragaToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem1.Text = "Novi događaj";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // organizacijeToolStripMenuItem
            // 
            this.organizacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem2,
            this.noviDogađajToolStripMenuItem});
            this.organizacijeToolStripMenuItem.Name = "organizacijeToolStripMenuItem";
            this.organizacijeToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.organizacijeToolStripMenuItem.Text = "Organizacije";
            // 
            // pretragaToolStripMenuItem2
            // 
            this.pretragaToolStripMenuItem2.Name = "pretragaToolStripMenuItem2";
            this.pretragaToolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.pretragaToolStripMenuItem2.Text = "Pretraga";
            this.pretragaToolStripMenuItem2.Click += new System.EventHandler(this.pretragaToolStripMenuItem2_Click);
            // 
            // noviDogađajToolStripMenuItem
            // 
            this.noviDogađajToolStripMenuItem.Name = "noviDogađajToolStripMenuItem";
            this.noviDogađajToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.noviDogađajToolStripMenuItem.Text = "Nova organizacija";
            this.noviDogađajToolStripMenuItem.Click += new System.EventHandler(this.noviDogađajToolStripMenuItem_Click);
            // 
            // kategorijeToolStripMenuItem
            // 
            this.kategorijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretražiToolStripMenuItem,
            this.novaKategorijaToolStripMenuItem});
            this.kategorijeToolStripMenuItem.Name = "kategorijeToolStripMenuItem";
            this.kategorijeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.kategorijeToolStripMenuItem.Text = "Kategorije";
            // 
            // pretražiToolStripMenuItem
            // 
            this.pretražiToolStripMenuItem.Name = "pretražiToolStripMenuItem";
            this.pretražiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.pretražiToolStripMenuItem.Text = "Pretraži";
            this.pretražiToolStripMenuItem.Click += new System.EventHandler(this.pretražiToolStripMenuItem_Click);
            // 
            // novaKategorijaToolStripMenuItem
            // 
            this.novaKategorijaToolStripMenuItem.Name = "novaKategorijaToolStripMenuItem";
            this.novaKategorijaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.novaKategorijaToolStripMenuItem.Text = "Nova kategorija";
            this.novaKategorijaToolStripMenuItem.Click += new System.EventHandler(this.novaKategorijaToolStripMenuItem_Click);
            // 
            // izvještajToolStripMenuItem
            // 
            this.izvještajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.događajiToolStripMenuItem});
            this.izvještajToolStripMenuItem.Name = "izvještajToolStripMenuItem";
            this.izvještajToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.izvještajToolStripMenuItem.Text = "Izvještaji";
            this.izvještajToolStripMenuItem.Click += new System.EventHandler(this.izvještajToolStripMenuItem_Click);
            // 
            // događajiToolStripMenuItem
            // 
            this.događajiToolStripMenuItem.Name = "događajiToolStripMenuItem";
            this.događajiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.događajiToolStripMenuItem.Text = "Događaji";
            this.događajiToolStripMenuItem.Click += new System.EventHandler(this.događajiToolStripMenuItem_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndex";
            this.Text = "EM Sistem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dogaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem organizacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem noviDogađajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretražiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaKategorijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem događajiToolStripMenuItem;
    }
}




namespace eventManagement.WinUI.Organizations
{
    partial class frmOrganizationDetails
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(179, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1026;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1025;
            this.label1.Text = "Naslov";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(22, 50);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 20);
            this.txtName.TabIndex = 1024;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating_1);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtLogo
            // 
            this.txtLogo.Location = new System.Drawing.Point(22, 76);
            this.txtLogo.MaxLength = 100;
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(232, 20);
            this.txtLogo.TabIndex = 1027;
            this.txtLogo.Visible = false;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(179, 102);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(75, 23);
            this.btnAddImage.TabIndex = 1029;
            this.btnAddImage.Text = "Dodaj sliku";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(72, 184);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(133, 99);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1030;
            this.pictureBox.TabStop = false;
            // 
            // frmOrganizationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 348);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.txtLogo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "frmOrganizationDetails";
            this.Text = "Organizacija";
            this.Load += new System.EventHandler(this.frmOrganizationDetails_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
namespace eventManagement.WinUI.Events
{
    partial class frmEventDetails
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.chxActive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCoatization = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaxPlaces = new System.Windows.Forms.TextBox();
            this.cbxCities = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxOrganizations = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxCountries = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvParticipants = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSpeakers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddSpeaker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeakers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(447, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1011;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 1013;
            this.label7.Text = "Adresa";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(12, 249);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(232, 20);
            this.txtAddress.TabIndex = 1005;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 1012;
            this.label6.Text = "Trajanje (minute)";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(12, 201);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(232, 20);
            this.txtDuration.TabIndex = 1004;
            this.txtDuration.Validating += new System.ComponentModel.CancelEventHandler(this.txtDuration_Validating);
            // 
            // chxActive
            // 
            this.chxActive.AutoSize = true;
            this.chxActive.Checked = true;
            this.chxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxActive.Location = new System.Drawing.Point(12, 333);
            this.chxActive.Name = "chxActive";
            this.chxActive.Size = new System.Drawing.Size(62, 17);
            this.chxActive.TabIndex = 1010;
            this.chxActive.Text = "Aktivan";
            this.chxActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 1011;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1008;
            this.label4.Text = "Kotizacija";
            // 
            // txtCoatization
            // 
            this.txtCoatization.Location = new System.Drawing.Point(12, 151);
            this.txtCoatization.Name = "txtCoatization";
            this.txtCoatization.Size = new System.Drawing.Size(232, 20);
            this.txtCoatization.TabIndex = 1003;
            this.txtCoatization.Validating += new System.ComponentModel.CancelEventHandler(this.txtCoatization_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 1005;
            this.label3.Text = "Datum i vrijeme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1003;
            this.label2.Text = "Opis";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(290, 48);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(232, 123);
            this.txtDescription.TabIndex = 1007;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1001;
            this.label1.Text = "Naslov";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 48);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 20);
            this.txtName.TabIndex = 1000;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 100);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker.TabIndex = 1002;
            this.dateTimePicker.Value = new System.DateTime(2020, 3, 5, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 1017;
            this.label8.Text = "Ukupno mjesta";
            // 
            // txtMaxPlaces
            // 
            this.txtMaxPlaces.Location = new System.Drawing.Point(12, 297);
            this.txtMaxPlaces.Name = "txtMaxPlaces";
            this.txtMaxPlaces.Size = new System.Drawing.Size(232, 20);
            this.txtMaxPlaces.TabIndex = 1006;
            this.txtMaxPlaces.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaxPlaces_Validating);
            // 
            // cbxCities
            // 
            this.cbxCities.FormattingEnabled = true;
            this.cbxCities.Location = new System.Drawing.Point(290, 248);
            this.cbxCities.Name = "cbxCities";
            this.cbxCities.Size = new System.Drawing.Size(232, 21);
            this.cbxCities.TabIndex = 1009;
            this.cbxCities.Validating += new System.ComponentModel.CancelEventHandler(this.cbxCities_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 1019;
            this.label9.Text = "Grad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 1021;
            this.label10.Text = "Organizacija";
            // 
            // cbxOrganizations
            // 
            this.cbxOrganizations.FormattingEnabled = true;
            this.cbxOrganizations.Location = new System.Drawing.Point(290, 296);
            this.cbxOrganizations.Name = "cbxOrganizations";
            this.cbxOrganizations.Size = new System.Drawing.Size(232, 21);
            this.cbxOrganizations.TabIndex = 1010;
            this.cbxOrganizations.Validating += new System.ComponentModel.CancelEventHandler(this.cbxOrganizations_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 1023;
            this.label11.Text = "Država";
            // 
            // cbxCountries
            // 
            this.cbxCountries.FormattingEnabled = true;
            this.cbxCountries.Location = new System.Drawing.Point(290, 201);
            this.cbxCountries.Name = "cbxCountries";
            this.cbxCountries.Size = new System.Drawing.Size(232, 21);
            this.cbxCountries.TabIndex = 1008;
            this.cbxCountries.SelectedIndexChanged += new System.EventHandler(this.cbxCountries_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(556, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 1024;
            this.label12.Text = "Učesnici";
            // 
            // dgvParticipants
            // 
            this.dgvParticipants.AllowUserToAddRows = false;
            this.dgvParticipants.AllowUserToDeleteRows = false;
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Username});
            this.dgvParticipants.Location = new System.Drawing.Point(559, 48);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.ReadOnly = true;
            this.dgvParticipants.Size = new System.Drawing.Size(493, 150);
            this.dgvParticipants.TabIndex = 1025;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Ime";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Prezime";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Korisničko ime";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // dgvSpeakers
            // 
            this.dgvSpeakers.AllowUserToAddRows = false;
            this.dgvSpeakers.AllowUserToDeleteRows = false;
            this.dgvSpeakers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpeakers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvSpeakers.Location = new System.Drawing.Point(559, 248);
            this.dgvSpeakers.Name = "dgvSpeakers";
            this.dgvSpeakers.ReadOnly = true;
            this.dgvSpeakers.Size = new System.Drawing.Size(493, 136);
            this.dgvSpeakers.TabIndex = 1027;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn1.HeaderText = "UserId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn5.HeaderText = "Korisničko ime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(556, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 1026;
            this.label13.Text = "Predavači";
            // 
            // btnAddSpeaker
            // 
            this.btnAddSpeaker.Location = new System.Drawing.Point(908, 212);
            this.btnAddSpeaker.Name = "btnAddSpeaker";
            this.btnAddSpeaker.Size = new System.Drawing.Size(144, 23);
            this.btnAddSpeaker.TabIndex = 1028;
            this.btnAddSpeaker.Text = "Dodaj predavača";
            this.btnAddSpeaker.UseVisualStyleBackColor = true;
            this.btnAddSpeaker.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 413);
            this.Controls.Add(this.btnAddSpeaker);
            this.Controls.Add(this.dgvSpeakers);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvParticipants);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbxCountries);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxOrganizations);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxCities);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaxPlaces);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.chxActive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCoatization);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "frmEventDetails";
            this.Text = "Dogđaj";
            this.Load += new System.EventHandler(this.frmEventDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeakers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.CheckBox chxActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCoatization;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaxPlaces;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxOrganizations;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxCities;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxCountries;
        private System.Windows.Forms.DataGridView dgvSpeakers;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvParticipants;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.Button btnAddSpeaker;
    }
}
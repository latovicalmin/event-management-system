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

namespace eventManagement.WinUI.Events
{
    public partial class frmEventDetails : Form
    {
        private readonly APIService _apiEvents = new APIService("events");
        private readonly APIService _apiOrganizations = new APIService("organizations");
        private readonly APIService _apiCountries = new APIService("countries");
        private readonly APIService _apiCities = new APIService("cities");

        private int? _id = null;
        private bool _formValid = true;
        Event _globalEvent = null;

        public frmEventDetails(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var cityId = cbxCities.SelectedValue;
            var organizationId = cbxOrganizations.SelectedValue;

            _formValid = true;
            ValidateChildren();

            foreach (Control c in errorProvider.ContainerControl.Controls)
                if (errorProvider.GetError(c) != "")
                    _formValid = false;

            if (_formValid)
            {
                EventUpsertRequest request = new EventUpsertRequest()
                {
                    Name = txtName.Text,
                    CreatedAt = DateTime.Now,
                    DateTime = dateTimePicker.Value,
                    Active = chxActive.Checked,
                    Address = txtAddress.Text,
                    Coatization = decimal.Parse(txtCoatization.Text),
                    Description = txtDescription.Text,
                    Duration = Math.Round(decimal.Parse(txtDuration.Text), 0),
                };

                if (int.TryParse(txtMaxPlaces.Text.ToString(), out int _maxPlaces))
                {
                    request.MaxPlaces = _maxPlaces;
                }


                if (int.TryParse(cityId?.ToString(), out int _cityId))
                {
                    request.CityId = _cityId;
                }

                if (int.TryParse(organizationId.ToString(), out int _organizationId))
                {
                    request.OrganizationId = _organizationId;
                }


                if (_id.HasValue)
                {
                    await _apiEvents.Update<Event>(_id.Value, request);
                    MessageBox.Show(Properties.Resources.Success_Update);
                }
                else
                {
                    await _apiEvents.Insert<Event>(request);
                    MessageBox.Show(Properties.Resources.Success_Insert);
                }
                this.Close();
            }

        }

        private async void frmEventDetails_Load(object sender, EventArgs e)
        {
            await LoadOrganizations();
            await LoadCountries();

            if (_id.HasValue)
            {
                var eventObj = await _apiEvents.GetById<Event>(_id);
                _globalEvent = eventObj;
                await LoadCities(eventObj.City.CountryId);

                txtName.Text = eventObj.Name;
                dateTimePicker.Value = eventObj.DateTime;
                chxActive.Checked = eventObj.Active;
                txtAddress.Text = eventObj.Address;
                txtCoatization.Text = eventObj.Coatization.ToString();
                txtDescription.Text = eventObj.Description;
                txtDuration.Text = eventObj?.Duration.ToString();
                txtMaxPlaces.Text = eventObj?.MaxPlaces.ToString();
                txtName.Text = eventObj.Name;

                cbxCities.SelectedIndex = cbxCities.FindStringExact(eventObj.City.Name);
                cbxOrganizations.SelectedIndex = cbxOrganizations.FindStringExact(eventObj.Organization.Name);

                fillDataGrids(eventObj);
            } else
            {
                dateTimePicker.Value = DateTime.Now;
                btnAddSpeaker.Visible = false;
            }
        }

        private void fillDataGrids(Event eventObj)
        {
            List<User> participantsList = new List<User>();
            foreach (var item in eventObj.Participants)
            {
                participantsList.Add(item.User);
            }
            dgvParticipants.AutoGenerateColumns = false;
            dgvParticipants.DataSource = participantsList;

            List<User> speakersList = new List<User>();
            foreach (var item in eventObj.Speakers)
            {
                speakersList.Add(item.User);
            }

            dgvSpeakers.AutoGenerateColumns = false;
            dgvSpeakers.DataSource = speakersList;
        }

        private async Task LoadOrganizations()
        {
            var result = await _apiOrganizations.Get<List<Organization>>();
            
            result.Insert(0, new Organization());
            cbxOrganizations.DisplayMember = "Name";
            cbxOrganizations.ValueMember = "OrganizationId";
            cbxOrganizations.DataSource = result;
        }
        private async Task LoadCountries()
        {
            var result = await _apiCountries.Get<List<Country>>();

            result.Insert(0, new Country());
            cbxCountries.DisplayMember = "Name";
            cbxCountries.ValueMember = "CountryId";
            cbxCountries.DataSource = result;
        }
        private async Task LoadCities(int? countryIdValue)
        {
            var countryId = cbxCountries.SelectedValue;

            if (int.TryParse(countryId.ToString(), out int id) || countryIdValue.HasValue == true)
            {
                if (id != 0 || countryIdValue.HasValue == true)
                {
                    id = id > 0 ? id : countryIdValue.Value;
                    var search = new CitySearchRequest()
                    {
                        CountryId = id
                    };
                    var result = await _apiCities.Get<List<City>>(search);

                    result.Insert(0, new City());
                    cbxCities.DisplayMember = "Name";
                    cbxCities.ValueMember = "CityId";
                    cbxCities.DataSource = result;
                } else
                {
                    cbxCities.DataSource = null;
                }
            } else
            {
                cbxCities.DataSource = null;
            }
        }

        private async void cbxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadCities(null);
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, Properties.Resources.Validation_RequiredField);
            }
            else if (txtName.Text.Length < 2 || txtName.Text.Length > 50)
            {
                errorProvider.SetError(txtName, Properties.Resources.Validation_Min2Max50);
            }
            else
            {
                errorProvider.SetError(txtName, null);
            }
        }

        private void txtCoatization_Validating(object sender, CancelEventArgs e)
        {
            float _coatization = 0;
            var isNumeric = float.TryParse(txtCoatization.Text, out _coatization);

            if (isNumeric && _coatization >= 0) 
            {
                errorProvider.SetError(txtCoatization, null);
            } else
            {
                errorProvider.SetError(txtCoatization, Properties.Resources.Validation_InputInvalid);
            }
        }

        private void txtDuration_Validating(object sender, CancelEventArgs e)
        {
            decimal _duration = 0;
            var isNumeric = decimal.TryParse(txtDuration.Text, out _duration);

            if (isNumeric && _duration >= 0)
            {
                errorProvider.SetError(txtDuration, null);
            }
            else
            {
                errorProvider.SetError(txtDuration, Properties.Resources.Validation_InputInvalid);
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddress.Text.Length > 100)
            {
                errorProvider.SetError(txtAddress, Properties.Resources.Validation_Max100);
            }
            else
            {
                errorProvider.SetError(txtAddress, null);
            }
        }

        private void txtMaxPlaces_Validating(object sender, CancelEventArgs e)
        {
            int _places = 0;
            var isNumeric = int.TryParse(txtMaxPlaces.Text, out _places);

            if (isNumeric && _places >= 0)
            {
                errorProvider.SetError(txtMaxPlaces, null);
            }
            else
            {
                errorProvider.SetError(txtMaxPlaces, Properties.Resources.Validation_InputInvalid);
            }
        }

        private void cbxCities_Validating(object sender, CancelEventArgs e)
        {
            var cityId = cbxCities.SelectedValue;
            if (cityId != null)
            {
                errorProvider.SetError(cbxCities, null);
            }
            else
            {
                errorProvider.SetError(cbxCities, Properties.Resources.Validation_InputInvalid);
            }
        }

        private void cbxOrganizations_Validating(object sender, CancelEventArgs e)
        {
            var organizationId = cbxOrganizations.SelectedValue;
            if (organizationId != null)
            {
                errorProvider.SetError(cbxOrganizations, null);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(cbxOrganizations, Properties.Resources.Validation_InputInvalid);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSpeaker frm = new frmSpeaker(_id.Value, _globalEvent);
            frm.Show();
        }
    }
}

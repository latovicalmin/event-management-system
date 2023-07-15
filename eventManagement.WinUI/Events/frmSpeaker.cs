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
    public partial class frmSpeaker : Form
    {
        private readonly APIService _apiUsers = new APIService("users");
        private readonly APIService _apiEvents = new APIService("events");

        private int _id = 0;
        private Event _eventObj = null;

        public frmSpeaker(int id, Event eventObj)
        {
            _id = id;
            _eventObj = eventObj;
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var speakerIDs = checkListSpeakers.CheckedItems.Cast<User>().Select(x => x.UserId).ToList();

            EventUpsertRequest request = new EventUpsertRequest()
            {
                Active = _eventObj.Active,
                Address = _eventObj.Address,
                CityId = _eventObj.CityId,
                Coatization = _eventObj.Coatization,
                CreatedAt = _eventObj.CreatedAt,
                DateTime = _eventObj.DateTime,
                Description = _eventObj.Description,
                Duration = _eventObj.Duration,
                MaxPlaces = _eventObj.MaxPlaces,
                Name = _eventObj.Name,
                OrganizationId = _eventObj.OrganizationId,
                SpeakerIDs = speakerIDs
            };

            await _apiEvents.Update<Event>(_id, request);
            MessageBox.Show(Properties.Resources.Success_Update);
            this.Close();
        }

        private async void frmSpeaker_Load(object sender, EventArgs e)
        {
            await LoadSpeakers();
            var speakers = _eventObj.Speakers.ToArray();

            for (int i = 0; i < checkListSpeakers.Items.Count; i++)
            {
                for (int j = 0; j < _eventObj.Speakers.Count; j++)
                {
                    var speakerItem = speakers[j];
                    User user = (User)checkListSpeakers.Items[i];

                    if (user.Name == speakerItem.User.Name)
                    {
                        checkListSpeakers.SetItemCheckState(i, CheckState.Checked);
                    }
                }
            }
        }

        private async Task<bool> LoadSpeakers()
        {
            UserSearchRequest search = new UserSearchRequest();
            search.RoleId = 4;

            var list = await _apiUsers.Get<IEnumerable<User>>(search);

            checkListSpeakers.DataSource = list;
            checkListSpeakers.DisplayMember = "Name";
            checkListSpeakers.ValueMember = "UserId";
            return true;
        }
    }
}

using eventManagement.Model;
using eventManagement.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eventManagement.MobileApp.ViewModels
{
    public class SpeakersViewModel : BaseViewModel
    {
        private readonly APIService _usersService = new APIService("users");

        public ObservableCollection<User> SpeakersList { get; set; } = new ObservableCollection<User>();
        public ICommand InitCommand { get; set; }

        string _speakerFirstName = null;
        public string FirstName {
            get { return _speakerFirstName; }
            set
            {
                SetProperty(ref _speakerFirstName, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        string _speakerLastName = null;
        public string LastName
        {
            get { return _speakerLastName; }
            set
            {
                SetProperty(ref _speakerLastName, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }


        public SpeakersViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
            UserSearchRequest search = new UserSearchRequest();
            search.FirstName = FirstName;
            search.LastName = LastName;
            search.RoleId = 4;

            var list = await _usersService.Get<IEnumerable<User>>(search);

            SpeakersList.Clear();
            foreach (var speaker in list)
            {
                SpeakersList.Add(speaker);
            }
        }
    }
}

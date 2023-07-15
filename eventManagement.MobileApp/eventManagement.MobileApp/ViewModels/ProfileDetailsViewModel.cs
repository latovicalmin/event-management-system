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
    public class ProfileDetailsViewModel : BaseViewModel
    {
        private readonly APIService _eventsService = new APIService("events");

        public ICommand InitCommand { get; set; }
        public ObservableCollection<Event> EventsList { get; set; } = new ObservableCollection<Event>();

        public User User { get; set; }

        public ProfileDetailsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
            EventSearchRequest search = new EventSearchRequest();
            search.UserId = User.UserId;

            var list = await _eventsService.Get<IEnumerable<Event>>(search);

            EventsList.Clear();
            foreach (var eventElement in list)
            {
                EventsList.Add(eventElement);
            }
        }
    }
}

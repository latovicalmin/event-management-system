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
    public class EventsViewModel : BaseViewModel
    {
        private readonly APIService _eventsService = new APIService("events");
        private readonly APIService _categoriesService = new APIService("categories");
        private readonly APIService _organizationsService = new APIService("organizations");

        public ObservableCollection<Category> CategoriesList { get; set; } = new ObservableCollection<Category>();
        public ObservableCollection<Organization> OrganizationsList { get; set; } = new ObservableCollection<Organization>();
        public ObservableCollection<Event> EventsList { get; set; } = new ObservableCollection<Event>();
        public ICommand InitCommand { get; set; }

        Category _selectedCategory = null;
        Organization _selectedOrganization = null;
        string _eventName = string.Empty;

        public Category SelectedCategory {
            get { return _selectedCategory; }
            set
            {
                SetProperty(ref _selectedCategory, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public Organization SelectedOrganization
        {
            get { return _selectedOrganization; }
            set
            {
                SetProperty(ref _selectedOrganization, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public string EventName
        {
            get { return _eventName; }
            set
            {
                SetProperty(ref _eventName, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public EventsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
            if (CategoriesList.Count == 0)
            {
                var categoryData = await _categoriesService.Get<IEnumerable<Category>>(null);

                CategoriesList.Insert(0, new Category { CategoryId = null, Name = "Kategorija..." });
                foreach (var categoryElement in categoryData)
                {
                    CategoriesList.Add(categoryElement);
                }
            }

            if (OrganizationsList.Count == 0)
            {
                var organizationsData = await _organizationsService.Get<IEnumerable<Organization>>(null);

                OrganizationsList.Insert(0, new Organization { OrganizationId = null, Name = "Kategorija..." });
                foreach (var categoryElement in organizationsData)
                {
                    OrganizationsList.Add(categoryElement);
                }
            }


            if (SelectedCategory != null || SelectedOrganization != null || !String.IsNullOrEmpty(EventName))
            {
                EventSearchRequest search = new EventSearchRequest();
                search.CategoryId = SelectedCategory?.CategoryId;
                search.OrganizationId = SelectedOrganization?.OrganizationId;
                search.Name = EventName;

                var list = await _eventsService.Get<IEnumerable<Event>>(search);

                EventsList.Clear();
                foreach (var eventElement in list)
                {
                    eventElement.DateTimeFormatted = eventElement.DateTime.ToString("dd.MM.yyyy h:mm tt");
                    EventsList.Add(eventElement);
                }
            }
            else
            {
                var list = await _eventsService.Get<IEnumerable<Event>>(null);

                EventsList.Clear();
                foreach (var eventElement in list)
                {
                    eventElement.DateTimeFormatted = eventElement.DateTime.ToString("dd.MM.yyyy h:mm tt");
                    EventsList.Add(eventElement);
                }
            }
        }
    }
}

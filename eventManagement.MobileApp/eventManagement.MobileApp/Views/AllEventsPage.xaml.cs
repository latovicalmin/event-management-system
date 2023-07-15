using eventManagement.MobileApp.ViewModels;
using eventManagement.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eventManagement.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllEventsPage : ContentPage
    {
        private EventsViewModel model = null;
        Organization Organization = null;
        public AllEventsPage(Organization organization = null)
        {
            Organization = organization;

            InitializeComponent();
            BindingContext = model = new EventsViewModel();
        }

        public AllEventsPage()
        {
            InitializeComponent();
            BindingContext = model = new EventsViewModel();
        }


        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            if (Organization != null)
            {
                setOrganizationSelected();
            }
        }

        private void setOrganizationSelected()
        {
            organizationsPicker.SelectedItem = ((ObservableCollection<Organization>)organizationsPicker.ItemsSource).ToList().Find(x => x.OrganizationId == Organization.OrganizationId);
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Event;
            item.DateTimeFormatted = item.DateTime.ToString("dd.MM.yyyy h:mm tt");
            await Navigation.PushAsync(new EventDetailsPage(item));
        }
    }
}
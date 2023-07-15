using eventManagement.MobileApp.ViewModels;
using eventManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eventManagement.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventDetailsPage : ContentPage
    {
        private EventDetailsViewModel model = null;
        public EventDetailsPage(Event eventModel)
        {
            InitializeComponent();
            BindingContext = model = new EventDetailsViewModel()
            {
                Event = eventModel
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            model.Recommend(model.Event.EventId);
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Speakers;
            await Navigation.PushAsync(new ProfilePage(item.User));
        }

        private async void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await model.RateEvent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await model.Participate();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await model.RemoveParticipate();
        }

        private async void ListView_ItemSelected_1(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Event;
            item.DateTimeFormatted = item.DateTime.ToString("dd.MM.yyyy h:mm tt");
            await Navigation.PushAsync(new EventDetailsPage(item));
        }
    }
}
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
    public partial class SpeakersPage : ContentPage
    {
        private SpeakersViewModel model = null;
        public SpeakersPage()
        {
            InitializeComponent();
            BindingContext = model = new SpeakersViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as User;
            await Navigation.PushAsync(new ProfilePage(item));
        }
    }
}
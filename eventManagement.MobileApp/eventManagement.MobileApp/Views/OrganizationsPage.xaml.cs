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
    public partial class OrganizationsPage : ContentPage
    {
        private OrganizationsViewModel model = null;
        public OrganizationsPage()
        {
            InitializeComponent();
            BindingContext = model = new OrganizationsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Organization;
            await Navigation.PushAsync(new AllEventsPage(item));
        }
    }
}
﻿using eventManagement.MobileApp.ViewModels;
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
    public partial class ProfilePage : ContentPage
    {
        private ProfileDetailsViewModel model = null;
        public ProfilePage(User user)
        {
            InitializeComponent();
            BindingContext = model = new ProfileDetailsViewModel()
            {
                User = user
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Event;
            item.DateTimeFormatted = item.DateTime.ToString("dd.MM.yyyy h:mm tt");
            await Navigation.PushAsync(new EventDetailsPage(item));
        }
    }
}
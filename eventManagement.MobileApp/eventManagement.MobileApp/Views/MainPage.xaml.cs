using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using eventManagement.MobileApp.Models;

namespace eventManagement.MobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.EventPage:
                        MenuPages.Add(id, new NavigationPage(new AllEventsPage()));
                        break;
                    case (int)MenuItemType.Organizations:
                        MenuPages.Add(id, new NavigationPage(new OrganizationsPage()));
                        break;
                    case (int)MenuItemType.Signup:
                        MenuPages.Add(id, new NavigationPage(new SignupPage()));
                        break;
                    case (int)MenuItemType.Speakers:
                        MenuPages.Add(id, new NavigationPage(new SpeakersPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Profile:
                        MenuPages.Add(id, new NavigationPage(new ProfilePage(Global.LoggedUser)));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}
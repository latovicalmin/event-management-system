using eventManagement.MobileApp.ViewModels;
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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            registerLabel.GestureRecognizers.Add(
            new TapGestureRecognizer()
            {
                Command = new Command(async () => {
                    App.Current.MainPage = new SignupPage();
                })
            });
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eventManagement.MobileApp.Views;
using eventManagement.Model;
using eventManagement.Model.Requests;
using Xamarin.Forms;

namespace eventManagement.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("users");
        private readonly APIService _rolesService = new APIService("roles");

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
                List<Role> roles = await _rolesService.Get<List<Role>>(null);

                UserSearchRequest search = new UserSearchRequest()
                {
                    Username = Username,
                };
                List<User> entity = await _service.Get<List<User>>(search);
                Global.LoggedUser = entity[0];
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Greška", "Korisničko ime ili lozinka nisu ispravni", "OK");
            }
        }
    }
}
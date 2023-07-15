using eventManagement.MobileApp.Views;
using eventManagement.Model;
using eventManagement.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eventManagement.MobileApp.ViewModels
{
    public class SignupViewModel : BaseViewModel
    {
        public ICommand signUpCommand { get; set; }

        private readonly APIService _service = new APIService("users");
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
        string _firstName = string.Empty;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }
        string _lastName = string.Empty;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        public SignupViewModel()
        {
            signUpCommand = new Command(async () => await SignUp());
        }

        async Task SignUp()
        {
            if (String.IsNullOrWhiteSpace(Username) || String.IsNullOrWhiteSpace(Password) || String.IsNullOrWhiteSpace(FirstName) || String.IsNullOrWhiteSpace(LastName) || String.IsNullOrWhiteSpace(Email))
            {
                await App.Current.MainPage.DisplayAlert("Greška", "Sva polja su obavezna!", "OK");
            }
            else
            {
                if (await validateFormFields())
                {
                    UserInsertRequest user = new UserInsertRequest();
                    user.FirstName = FirstName;
                    user.LastName = LastName;
                    user.Username = Username;
                    user.Password = Password;
                    user.PasswordConfirmation = Password;
                    user.Email = Email;
                    user.Active = true;
                    var entity = await _service.Insert<User>(user);
                    if (entity != null)
                    {
                        APIService.Username = Username;
                        APIService.Password = Password;
                        Global.LoggedUser = entity;
                        Application.Current.MainPage = new MainPage();
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Greška", "Problem s registracijom", "OK");
                        Application.Current.MainPage = new LoginPage();
                    }
                }
            }
        }

        private async Task<bool> validateFormFields()
        {
            if (FirstName.Length < 2 || FirstName.Length > 50)
            {
                await App.Current.MainPage.DisplayAlert("Greška", "Ime treba biti minimalno 2 a maksimalno 50 karaktera", "OK");
                return false;
            }
            if (LastName.Length < 2 || LastName.Length > 50)
            {
                await App.Current.MainPage.DisplayAlert("Greška", "Prezime treba biti minimalno 2 a maksimalno 50 karaktera", "OK");
                return false;
            }
            if (Email.Length < 3 || Email.Length > 100)
            {
                await App.Current.MainPage.DisplayAlert("Greška", "Email treba biti minimalno 3 a maksimalno 100 karaktera", "OK");
                return false;
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (!regex.Match(Email).Success)
            {
                await App.Current.MainPage.DisplayAlert("Greška", "Email nije validan", "OK");
                return false;
            }

            if (Username.Length < 2 || Username.Length > 20)
            {
                await App.Current.MainPage.DisplayAlert("Greška", "Korisničko ime treba biti minimalno 2 a maksimalno 20 karaktera", "OK");
                return false;
            }

            if (Username.Length < 2 || Username.Length > 20)
            {
                await App.Current.MainPage.DisplayAlert("Greška", "Korisničko ime treba biti minimalno 2 a maksimalno 20 karaktera", "OK");
                return false;
            }

            if (Password.Length < 2 || Password.Length > 20)
            {
                await App.Current.MainPage.DisplayAlert("Greška", "Lozinka treba biti minimalno 2 a maksimalno 20 karaktera", "OK");
                return false;
            }

            return true;
        }
    }
}

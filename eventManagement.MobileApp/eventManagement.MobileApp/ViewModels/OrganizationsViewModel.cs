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
    public class OrganizationsViewModel : BaseViewModel
    {
        private readonly APIService _organizationsService = new APIService("organizations");

        public ObservableCollection<Organization> OrganizationsList { get; set; } = new ObservableCollection<Organization>();
        public ICommand InitCommand { get; set; }

        string _organizationName = null;
        public string OrganizationName {
            get { return _organizationName; }
            set
            {
                SetProperty(ref _organizationName, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public OrganizationsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
            if (!String.IsNullOrEmpty(_organizationName))
            {
                OrganizationsSearchRequest search = new OrganizationsSearchRequest();
                search.Name = _organizationName;

                var list = await _organizationsService.Get<IEnumerable<Organization>>(search);

                OrganizationsList.Clear();
                foreach (var organizationElement in list)
                {
                    OrganizationsList.Add(organizationElement);
                }
            } else
            {
                var list = await _organizationsService.Get<IEnumerable<Organization>>(null);

                OrganizationsList.Clear();
                foreach (var organizationElement in list)
                {
                    OrganizationsList.Add(organizationElement);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using pcso_group_three.Model;
using pcso_group_three.Services;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json;

namespace pcso_group_three.ViewModel
{
    public partial class OrganizationViewModel : BaseViewModel
    {
        OfficerService officerService;
        public ObservableCollection<Officer> Officers { get; } = new ObservableCollection<Officer>();

        public OrganizationViewModel(OfficerService officerService)
        {
            Title = "Organization";
            this.officerService = officerService;
            OnInitializedAsync();
        }

        //[ICommand]
        async Task OnInitializedAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var officers = await officerService.GetOfficers();

                if (officers.Count != 0)
                {
                    Officers.Clear();
                }
                foreach (var officer in officers)
                {
                    Officers.Add(officer);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!",
                    $"Unabale to get Officer: {ex.Message}", "OK");

            }
            finally
            {
                IsBusy = false;
            }
        }

        [ICommand]
        public void GoToHome()
        {
            Shell.Current.GoToAsync("//Tabs");
        }

        [ICommand]
        public void GoToChairpersonPage()
        {
            Shell.Current.GoToAsync("//Chairperson");
        }
    }
}

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
using pcso_group_three.View;

namespace pcso_group_three.ViewModel
{
    public partial class BODViewModel : BaseViewModel
    {
        OfficeService officeService;

        public ObservableCollection<Office> Offices { get; } = new ObservableCollection<Office>();

        public BODViewModel(OfficeService officeService)
        {
            Title = "Organization";
            this.officeService = officeService;
            //OnInitializedAsync();
            GetByOfficeIDAsync(1);
        }

        [ICommand]
        async Task GoToOfficerDetailsAsync(Office office)
        {
            if (office is null)
                return;

            await Shell.Current.GoToAsync($"{nameof(OfficerDetailsPage)}", true,
                    new Dictionary<string, object>
                    {
                        {"Office", office}
                    });

        }


        //[ICommand]
        async Task OnInitializedAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var offices = await officeService.GetOffices();

                if (offices.Count != 0)
                {
                    Offices.Clear();
                }
                foreach (var office in offices)
                {
                    Offices.Add(office);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!",
                    $"Unabale to get Office: {ex.Message}", "OK");

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

        async Task GetByOfficeIDAsync(int officeid)
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var offices = await officeService.GetOfficesByOfficeid(officeid);

                if (offices.Count != 0)
                {
                    Offices.Clear();
                }
                foreach (var office in offices)
                {
                    Offices.Add(office);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!",
                    $"Unabale to get Office: {ex.Message}", "OK");

            }
            finally
            {
                IsBusy = false;
            }
        }

    }
}

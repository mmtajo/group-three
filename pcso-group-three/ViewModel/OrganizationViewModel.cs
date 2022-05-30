using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using CommunityToolkit.Mvvm.Input;

namespace pcso_group_three.ViewModel
{
    public partial class OrganizationViewModel : BaseViewModel
    {
        [ICommand]
        public void GoToHome()
        {
            Shell.Current.GoToAsync("//Tabs");
        }

    }
}

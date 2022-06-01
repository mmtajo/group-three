using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace pcso_group_three.ViewModel
{
    public partial class HomeViewModel : BaseViewModel
    {
        [ICommand]
        public void GoToOrganizationPage()
        {
            Shell.Current.GoToAsync("//Organization");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace pcso_group_three.ViewModel
{
    public partial class OBSViewModel : BaseViewModel
    {
        [ICommand]
        public void GoToHome()
        {
            Shell.Current.GoToAsync("//Tabs");
        }
    }
}

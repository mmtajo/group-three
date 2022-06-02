using CommunityToolkit.Mvvm.ComponentModel;
using pcso_group_three.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcso_group_three.ViewModel
{
    //[QueryProperty("Officer", "Officer")]
    [QueryProperty("Office", "Office")]
    public partial class OfficerDetailsViewModel : BaseViewModel
    {
        public OfficerDetailsViewModel()
        {
        }

        [ObservableProperty]
        //Officer officer;
        Office office;
    }
}

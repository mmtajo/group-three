﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using pcso_group_three.Services;
using pcso_group_three.Model;
using System.Diagnostics;

namespace pcso_group_three.ViewModel
{

    public partial class HomeViewModel : BaseViewModel
    {


        [ICommand]
        public void GoToOrganizationPage()
        {
            Shell.Current.GoToAsync("//Organization");
        }

        //OFFICES
        [ICommand]
        public void GoToBODPage()
        {
            Shell.Current.GoToAsync("//BOD");
        }
        [ICommand]
        public void GoToOCPage()
        {
            Shell.Current.GoToAsync("//OC");
        }
        [ICommand]
        public void GoToOBSPage()
        {
            Shell.Current.GoToAsync("//OBS");
        }
        [ICommand]
        public void GoToOGMPage()
        {
            Shell.Current.GoToAsync("//OGM");
        }

    }
}

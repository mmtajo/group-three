using pcso_group_three.ViewModel;
using pcso_group_three.Services;

namespace pcso_group_three.View;

public partial class HomePage : ContentPage
{
    
    public HomePage(HomeViewModel homeViewModel)
    {
        InitializeComponent();
        BindingContext = homeViewModel;
    }

    private void SampleButton_Clicked(object sender, EventArgs e)
    {
        
    }
}
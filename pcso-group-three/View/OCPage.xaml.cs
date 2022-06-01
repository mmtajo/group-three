using pcso_group_three.ViewModel;
namespace pcso_group_three.View;

public partial class OCPage : ContentPage
{
	public OCPage(OCViewModel oCViewModel)
	{
		InitializeComponent();
        BindingContext = oCViewModel;
    }
}
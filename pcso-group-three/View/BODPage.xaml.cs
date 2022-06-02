using pcso_group_three.ViewModel;
namespace pcso_group_three.View;

public partial class BODPage : ContentPage
{
	public BODPage(BODViewModel bODViewModel)
	{
		InitializeComponent();
		BindingContext = bODViewModel;
    }
}
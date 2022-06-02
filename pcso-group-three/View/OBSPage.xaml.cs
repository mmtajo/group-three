using pcso_group_three.ViewModel;
namespace pcso_group_three.View;

public partial class OBSPage : ContentPage
{
	public OBSPage(OBSViewModel oBSViewModel)
	{
        InitializeComponent();
        BindingContext = oBSViewModel;
    }
}
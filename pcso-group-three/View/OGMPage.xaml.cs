using pcso_group_three.ViewModel;
namespace pcso_group_three.View;

public partial class OGMPage : ContentPage
{
	public OGMPage(OGMViewModel oGMViewModel)
	{
		InitializeComponent();
        BindingContext = oGMViewModel;
    }
}
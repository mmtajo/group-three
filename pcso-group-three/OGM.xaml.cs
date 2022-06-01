using pcso_group_three.ViewModel;
namespace pcso_group_three;

public partial class OGM : ContentPage
{
	public OGM(OGMViewModel oGMViewModel)
	{
		InitializeComponent();
        BindingContext = oGMViewModel;
    }
}
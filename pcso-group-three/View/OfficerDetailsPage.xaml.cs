using pcso_group_three.ViewModel;

namespace pcso_group_three.View;

public partial class OfficerDetailsPage : ContentPage
{
	public OfficerDetailsPage(OfficerDetailsViewModel officerDetailsViewModel)
	{
		InitializeComponent();
        BindingContext = officerDetailsViewModel;
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}
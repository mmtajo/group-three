using pcso_group_three.ViewModel;
namespace pcso_group_three.View;

public partial class ChairpersonPage : ContentPage
{
	public ChairpersonPage(ChairpersonViewModel chairpersonViewModel)
	{
		InitializeComponent();
        BindingContext = chairpersonViewModel;
    }
}
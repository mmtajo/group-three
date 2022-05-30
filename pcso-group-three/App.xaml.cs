namespace pcso_group_three;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
        Shell.Current.GoToAsync("//Tabs");
    }
}

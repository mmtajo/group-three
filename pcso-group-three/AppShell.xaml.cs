using pcso_group_three.View;

namespace pcso_group_three;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(OfficerDetailsPage), typeof(OfficerDetailsPage));
    }
}

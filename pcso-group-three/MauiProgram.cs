using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Markup;
using pcso_group_three.Services;
using pcso_group_three.View;
using pcso_group_three.ViewModel;

namespace pcso_group_three;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitCore()
            .UseMauiCommunityToolkitMarkup()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<OfficerService>();

        builder.Services.AddSingleton<HomeViewModel>();
        builder.Services.AddSingleton<HomePage>();

        builder.Services.AddSingleton<OrganizationViewModel>();
        builder.Services.AddTransient<OfficerDetailsViewModel>();

        builder.Services.AddSingleton<OrganizationPage>();
        builder.Services.AddTransient<OfficerDetailsPage>();

        builder.Services.AddSingleton<BODPage>();
        builder.Services.AddSingleton<BODViewModel>();

        builder.Services.AddSingleton<OCPage>();
        builder.Services.AddSingleton<OCViewModel>();

        builder.Services.AddSingleton<OBSPage>();
        builder.Services.AddSingleton<OBSViewModel>();

        builder.Services.AddSingleton<OGMPage>();
        builder.Services.AddSingleton<OGMViewModel>();

        builder.Services.AddSingleton<OfficeService>();

        return builder.Build();
	}
}

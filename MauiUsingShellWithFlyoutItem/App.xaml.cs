namespace MauiUsingShellWithFlyoutItem;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}

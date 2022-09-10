namespace MauiFlyoutPresentedBug;

public partial class App : Application
{

	public AppShell anAppShell;

	public App()
	{
		InitializeComponent();
		anAppShell = new AppShell();
		MainPage = anAppShell;
	}
}

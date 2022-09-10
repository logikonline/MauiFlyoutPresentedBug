namespace MauiFlyoutPresentedBug;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		MainThread.BeginInvokeOnMainThread(() =>
		{
			((App)Application.Current).anAppShell.FlyoutIsPresented = true;
		});
	}
}


using MauiApp1.Pages;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnRegisterClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new RegisterPage());
    }

	private void OnLoginClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new LoginPage());
	}//testing the git if we are on the right track
}


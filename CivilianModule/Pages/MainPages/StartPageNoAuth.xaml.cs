using CivilianModule.Pages.Other;
using CivilianModule;

namespace CivilianModule.Pages.MainPages;

public partial class StartPageNoAuth : ContentPage
{
	public StartPageNoAuth()
	{
		InitializeComponent();
	}

    private async void Button_Auth(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}
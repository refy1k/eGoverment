namespace CivilianModule.Pages.Other;

public partial class SpecialSettings : ContentPage
{
	public SpecialSettings()
	{
		InitializeComponent();
    }

    private void SwitchThemeApp(object sender, EventArgs e)
    {
        if (Application.Current.UserAppTheme == AppTheme.Dark)
        {
            Application.Current.UserAppTheme = AppTheme.Light;
        }
        else
        {
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
    }
}
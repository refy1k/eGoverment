using CivilianModule.Pages.Other;

namespace CivilianModule
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnOpenSpecialFeatures(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SpecialSettings());
        }
    }
}

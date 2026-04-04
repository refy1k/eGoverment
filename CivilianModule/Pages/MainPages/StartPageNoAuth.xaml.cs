using System.Collections.ObjectModel;

namespace CivilianModule.Pages.MainPages;

public partial class StartPageNoAuth : ContentPage
{
    public ObservableCollection<BannerItem> Banners { get; set; }
    public StartPageNoAuth()
    {
        InitializeComponent();

        Banners = new ObservableCollection<BannerItem>
        {
            new BannerItem
            {
                Image = "max_banner.png",
                Title = "Канал в MAX",
                Action = "https://max.ru/id5918217655_gos",
                IsExternal = true
            },
            new BannerItem
            {
                Image = "banner2.png",
                Title = "Обращения граждан",
                Action = "AppealsPage",
                IsExternal = false
            }
        };

        BindingContext = this;
    }

    private async void OnBannerTapped(object sender, TappedEventArgs e)
    {
        if (sender is not Border border)
            return;

        if (border.BindingContext is not BannerItem banner)
            return;

        if (banner.IsExternal)
        {
            await Launcher.Default.OpenAsync(new Uri(banner.Action));
        }
        else
        {
            await DisplayAlert("Навигация", $"Открыть страницу: {banner.Action}", "OK");
        }
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Авторизация", "Здесь позже будет переход на страницу входа.", "OK");
    }

    private async void OnBannerOpenClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Баннер", "Позже здесь будет переход на экран выбранной услуги.", "OK");
    }

    private async void OnAppealsClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Обращения", "Раздел обращений пока в разработке.", "OK");
    }

    private async void OnDocumentsClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Документы", "Раздел документов пока в разработке.", "OK");
    }

    private async void OnHousingClicked(object sender, EventArgs e)
    {
        await DisplayAlert("ЖКХ и услуги", "Раздел услуг пока в разработке.", "OK");
    }

    private async void OnTkoClicked(object sender, EventArgs e)
    {
        await DisplayAlert("ТКО", "Раздел ТКО пока в разработке.", "OK");
    }

    private async void OnNewsClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Новости", "Позже здесь будет экран с новостями и объявлениями.", "OK");
    }

    private async void OnProfileClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Личный кабинет", "После авторизации здесь будет открыт профиль гражданина.", "OK");
    }
}
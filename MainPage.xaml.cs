namespace Silberstadt;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnHistoryClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HistoryPage());
    }

    private async void OnFamousPeopleClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FamousPage());
    }

    private async void OnWebsideClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WebViewPage());
    }
}


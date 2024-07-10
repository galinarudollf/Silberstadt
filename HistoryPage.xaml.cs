namespace Silberstadt;
public partial class HistoryPage : ContentPage
{
    public HistoryPage()
    {
        InitializeComponent();
    }
    private async void OnOpenWebLinkClicked(object sender, EventArgs e)
    {
            // URL to be opened
            string url = "https://de.wikipedia.org/wiki/Freiberg";

            if (Uri.TryCreate(url, UriKind.Absolute, out Uri? uri))
            {
                await Launcher.Default.OpenAsync(uri);
            }
            else
            {
                await DisplayAlert("Fehler", "Ungültige URL", "OK");
            }
    }
}
//Quelle: https://de.wikipedia.org/wiki/Freiberg
using System.Net.Http.Json;

namespace PugaDExamenP2.Views;


public partial class ChistesPage : ContentPage
{
    private readonly HttpClient client = new();

    public ChistesPage()
    {
        InitializeComponent();
        CargarChiste();
    }

    private async void CargarChiste()
    {
        try
        {
            var chiste = await client.GetFromJsonAsync<Chiste>("https://official-joke-api.appspot.com/random_joke");

            if (chiste != null)
                chisteLabel.Text = $"{chiste.Setup}\n\n{chiste.Punchline}";
            else
                chisteLabel.Text = "No se pudo cargar el chiste.";
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "OK");
            chisteLabel.Text = "Error al cargar el chiste.";
        }
    }

    private void OtroChisteClicked(object sender, EventArgs e)
    {
        CargarChiste();
    }
    public class Chiste
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Setup { get; set; }
        public string Punchline { get; set; }
    }
}
using Microsoft.Maui.Controls;
using System.Threading.Tasks;

namespace PugaDExamenP2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }




        private async void ChisteBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ());

        }

        private async void Informacion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ());
        }
    }

}

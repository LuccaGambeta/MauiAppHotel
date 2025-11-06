using MauiAppHotel.Views;

namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void AbrirContratacao_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContratacaoHospedagem());
        }

        private async void AbrirFotos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FotosPage());
        }

        private async void AbrirSobre_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SobrePage());
        }
    }
}

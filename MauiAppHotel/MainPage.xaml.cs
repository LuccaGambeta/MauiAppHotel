namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterBtn.Text = count == 1 ? $"Reservado {count} vez" : $"Reservado {count} vezes";
            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.SobrePage());
        }

        private async void OnContratarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.ContratacaoHospedagem());
        }
    }
}

namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        public ContratacaoHospedagem()
        {
            InitializeComponent();
        }

        private async void Contratar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtDias.Text) || pckQuarto.SelectedIndex == -1)
            {
                await DisplayAlert("Atenção", "Preencha todos os campos antes de prosseguir.", "OK");
                return;
            }

            int dias = int.Parse(txtDias.Text);
            double valorDiaria = pckQuarto.SelectedIndex switch
            {
                0 => 100,
                1 => 180,
                2 => 250,
                _ => 0
            };

            double total = dias * valorDiaria;
            await Navigation.PushAsync(new HospedagemContratada(txtNome.Text, pckQuarto.SelectedItem.ToString(), dias, total));
        }
    }
}

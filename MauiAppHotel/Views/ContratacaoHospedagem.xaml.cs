namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        public ContratacaoHospedagem()
        {
            InitializeComponent();
        }

        private async void ConfirmarHospedagem_Clicked(object sender, EventArgs e)
        {
            string nome = entryNome.Text;
            string dias = entryDias.Text;
            string quarto = pickerQuarto.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(dias) || quarto == null)
            {
                await DisplayAlert("Erro", "Por favor, preencha todos os campos.", "OK");
                return;
            }

            await Navigation.PushAsync(new HospedagemContratada(nome, dias, quarto));
        }
    }
}

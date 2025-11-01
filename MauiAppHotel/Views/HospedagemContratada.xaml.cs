namespace MauiAppHotel.Views
{
    public partial class HospedagemContratada : ContentPage
    {
        public HospedagemContratada(string nome, string quarto, int dias, double total)
        {
            InitializeComponent();
            lblNome.Text = $"Hóspede: {nome}";
            lblQuarto.Text = $"Quarto: {quarto}";
            lblDias.Text = $"Dias: {dias}";
            lblTotal.Text = $"Total a pagar: R$ {total:F2}";
        }

        private async void Voltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

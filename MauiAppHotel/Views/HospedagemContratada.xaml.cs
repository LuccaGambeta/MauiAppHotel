namespace MauiAppHotel.Views
{
    public partial class HospedagemContratada : ContentPage
    {
        public HospedagemContratada(string nome, string dias, string quarto)
        {
            InitializeComponent();

            int qtdDias = int.TryParse(dias, out int result) ? result : 0;
            decimal valorDiaria = 0;

            if (quarto.Contains("Standard")) valorDiaria = 200;
            else if (quarto.Contains("Luxo")) valorDiaria = 350;
            else if (quarto.Contains("Presidencial")) valorDiaria = 500;

            decimal total = qtdDias * valorDiaria;

            lblResumo.Text = $"Cliente: {nome}\n" +
                             $"Tipo de quarto: {quarto}\n" +
                             $"Dias: {qtdDias}\n" +
                             $"Valor total: R$ {total:N2}";
        }

        private async void Voltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}

namespace AppHotel;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        lblHospedes.Text =
            $"{stepHospedes.Value:F0} hóspede(s)";
    }

    private async void Reservar_Clicked(object sender, EventArgs e)
    {
        if (pkQuarto.SelectedItem == null)
        {
            await DisplayAlert(
                "Atenção",
                "Selecione um tipo de quarto.",
                "OK");

            return;
        }

        string quarto = pkQuarto.SelectedItem.ToString();

        await DisplayAlert(
            "Reserva Confirmada",
            $"✅ Reserva realizada com sucesso!\n\n" +
            $"Quarto: {quarto}\n" +
            $"Hóspedes: {stepHospedes.Value:F0}\n" +
            $"Check-in: {dtEntrada.Date:dd/MM/yyyy}\n" +
            $"Check-out: {dtSaida.Date:dd/MM/yyyy}",
            "OK");
    }

    private async void Sobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobrePage());
    }
}

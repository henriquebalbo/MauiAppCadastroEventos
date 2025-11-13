using MauiAppCadastroEventos.Models;

namespace MauiAppEventos.Views;

public partial class CadastroEvento : ContentPage
{
    public CadastroEvento()
    {
        InitializeComponent();
    }

    private async void OnCadastrarClicked(object sender, EventArgs e)
    {
        try
        {
            Evento evento = new Evento
            {
                Nome = txtNome.Text,
                DataInicio = dtInicio.Date,
                DataTermino = dtTermino.Date,
                NumeroParticipantes = int.Parse(txtParticipantes.Text),
                Local = txtLocal.Text,
                CustoPorParticipante = double.Parse(txtCusto.Text)
            };

            await Navigation.PushAsync(new ResumoEvento
            {
                BindingContext = evento
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", "Verifique os dados inseridos: " + ex.Message, "OK");
        }
    }
}

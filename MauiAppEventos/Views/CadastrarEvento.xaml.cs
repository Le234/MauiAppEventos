


using MauiAppEventos.Model;

namespace MauiAppEventos.Views;


public partial class CadastrarEvento : ContentPage
{


    public CadastrarEvento()

    {
        InitializeComponent();
    }


    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Cadastro c = new Cadastro
            {
                NomeEvento = EntryNomeEvento.Text,
                DataInicio = DatePickerInicio.Date,
                DataTermino = DatePickerTermino.Date,
                LocalEvento = EntryLocalEvento.Text,
                NumeroParticipantes = Convert.ToInt32(EntryNumeroParticipantes.Text),
                CustoPorParticipante = Convert.ToInt32(EntryCustoPorParticipante.Text),
            };

            await Navigation.PushAsync(new EventoCadstrado()
            {
                BindingContext = c

            });


        }
        catch (Exception ex)

        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }

    }

    
}








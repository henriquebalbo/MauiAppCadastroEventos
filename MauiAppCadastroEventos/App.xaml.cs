using MauiAppCadastroEventos.Models;
using MauiAppEventos.Views;

namespace MauiAppCadastroEventos;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new CadastroEvento());
    }
}

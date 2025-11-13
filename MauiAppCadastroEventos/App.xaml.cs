using MauiAppCadastroEventos.Models;
using MauiAppEventos.Views;

namespace MauiAppCadastroEventos;

public partial class App : Application
{
    private const int V = 200;

    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new CadastroEvento());
    }
    protected override Window CreateWindow(IActivationState? activationState)
    {
        var window = base.CreateWindow(activationState);

        window.Width = 350;
        window.Height =500;

        return window;
    }




}

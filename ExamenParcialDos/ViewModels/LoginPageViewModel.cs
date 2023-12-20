using ExamenParcialDos.Models;
using ExamenParcialDos.Services;
using ExamenParcialDos.Services.Interfaces;
namespace ExamenParcialDos.ViewModels;
public class LoginPageViewModel
{
    private readonly IInicioDeSesion inicioDeSesion;

    public UsuarioRegistro Usuario { get; set; }

    public Command LoginCommand { get; set; }

    public LoginPageViewModel(IInicioDeSesion inicioDeSesion)
    {
        this.inicioDeSesion = inicioDeSesion;
        Usuario = new UsuarioRegistro();
        LoginCommand = new Command(LoginAsync);
    }
    private async void LoginAsync()
    {
        var validacion = await inicioDeSesion.ValidarCorreo(Usuario.Email, Usuario.Password);
        if (validacion == false)
        {
            await Util.ShowToastAsync("No fue posible iniciar sesion");
            return;
        }
        Util.ShowToastAsync("Inicio de sesión exitoso");
        await Shell.Current.GoToAsync($"///{nameof(Encuesta)}");
    }
}

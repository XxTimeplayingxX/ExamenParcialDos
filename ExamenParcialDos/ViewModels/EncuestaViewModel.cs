using ExamenParcialDos.Models;
namespace ExamenParcialDos.ViewModels;

public class EncuestaViewModel
{
    public Respuestas Respuestas { get; set; }
    public Command ValidarCommand { get; set; }
    public Command ValidarRespuestasCommand { get; set; }

    public EncuestaViewModel()
    {
        Respuestas = new Respuestas();
        ValidarCommand = new Command(Validar);
        ValidarRespuestasCommand = new Command(ValidarRespuestas);

    }
    public async void Validar()
    {
        if(Convert.ToInt32(Respuestas.Respuesta1)  == Convert.ToInt32("0") || 
            Convert.ToDouble(Respuestas.Respuesta2) == Convert.ToDouble("0") ||
            Convert.ToInt32(Respuestas.Respuesta3) == Convert.ToInt32("0"))
        {
            await Util.ShowToastAsync("Uno de los campos está vacío");
            return;
        }
        else
        {
            await Util.ShowToastAsync("Todos los campos están llenos");
            return;
        }
    }
    public async void ValidarRespuestas()
    {
        if((Respuestas.Respuesta1 == Convert.ToInt32("4")) &&
            (Respuestas.Respuesta2 == Convert.ToDouble("3.1416"))&&
            (Respuestas.Respuesta3 == Convert.ToInt32("5")))
        {
            await Util.ShowToastAsync("Todas las Respuetas son correctas");
            return;
        }
        else
        {
            await Util.ShowToastAsync("Respuetas Incorrectas");
            return;
        }
    }
}

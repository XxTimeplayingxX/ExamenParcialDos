using ExamenParcialDos.Models;
using ExamenParcialDos.Services.Interfaces;

namespace ExamenParcialDos.ViewModels;

public class EncuestaViewModel
{
    private readonly IEncuesta encuesta;

    public Respuestas Respuestas { get; set; }
    public Command ValidarCommand { get; set; }
    public Command ValidarRespuestasCommand { get; set; }

    public EncuestaViewModel(IEncuesta encuesta)
    {
        Respuestas = new Respuestas();
        ValidarCommand = new Command(Validar);
        ValidarRespuestasCommand = new Command(ValidarRespuestas);
        this.encuesta = encuesta;
    }
    public async void Validar()
    {
         var respuesta = await encuesta.Validar(Respuestas.Respuesta1,
             Respuestas.Respuesta2, 
             Respuestas.Respuesta3);
        if(respuesta == false)
        {
            Util.ShowToastAsync("Uno de los campos está vacío");
            return;
        }
        await Util.ShowToastAsync("Todos los campos están llenos");

    }
    public async void ValidarRespuestas()
    {
        var respuesta = await encuesta.ValidarRespuesta(Respuestas.Respuesta1,
             Respuestas.Respuesta2,
             Respuestas.Respuesta3);
        if (respuesta == true)
        {
            Util.ShowToastAsync("Todas las Respuetas son correctas");
            return;
        }
        await Util.ShowToastAsync("Respuetas Incorrectas");
    }
}

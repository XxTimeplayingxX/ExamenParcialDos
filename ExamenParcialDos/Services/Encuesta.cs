using ExamenParcialDos.Services.Interfaces;

namespace ExamenParcialDos.Services;

public class Encuesta : IEncuesta
{
    public async Task<bool> Validar(int respuesta1, double respuesta2, int respuesta3)
    {
        
        if(respuesta1 == Convert.ToInt32("0") || 
           respuesta2 == Convert.ToDouble("0") ||
           respuesta3 == Convert.ToInt32("0"))
        {
            //Util.ShowToastAsync("Uno de los campos está vacío");
            return false;
        }
        else
        {
            //await Util.ShowToastAsync("Todos los campos están llenos");
            return true;
        }
    }

    public async Task<bool>  ValidarRespuesta(int respuesta1, double respuest2, int respuesta3)
    {
        if ((respuesta1 == Convert.ToInt32("4")) &&
            (respuest2 == Convert.ToDouble("3.1416")) &&
            (respuesta3 == Convert.ToInt32("5")))
        {
            //await Util.ShowToastAsync("Todas las Respuetas son correctas");
            return true;
        }
        else
        {
            //await Util.ShowToastAsync("Respuetas Incorrectas");
            return false;
        }
    }
}

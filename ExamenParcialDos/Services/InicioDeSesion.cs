using ExamenParcialDos.Services.Interfaces;

namespace ExamenParcialDos.Services;

public class InicioDeSesion : IInicioDeSesion
{
    public async Task<bool> ValidarCorreo(string usuario, string password)
    {
        var result = false;
        if (string.IsNullOrEmpty(usuario))
        {
            return result;
        }
        if (string.IsNullOrEmpty(password))
        {
            return result;
        }

        if(usuario != "gustavo@gmail.com" && password != "12345.")
        {
            return false;
        }
        return true;
    }
    
}

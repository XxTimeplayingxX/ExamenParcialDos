namespace ExamenParcialDos.Services.Interfaces;

public interface IInicioDeSesion
{
    public Task<bool> ValidarCorreo(string usuario, string password);
}

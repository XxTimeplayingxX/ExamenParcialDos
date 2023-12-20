namespace ExamenParcialDos.Services.Interfaces
{
    public interface IEncuesta
    {
        public Task<bool> Validar(int respuesta1, double respuesta2, int respuesta3);
        public Task<bool> ValidarRespuesta(int respuesta1, double respuest2, int respuesta3);
    }
}

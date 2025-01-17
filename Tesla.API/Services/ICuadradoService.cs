namespace Tesla.Services
{
    using Tesla.Models;

    public interface ICuadradoService
    {
        Task<Cuadrado> Area(int lado);
    }
}
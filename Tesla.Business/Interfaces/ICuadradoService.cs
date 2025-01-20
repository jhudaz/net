using Tesla.Models;

namespace Tesla.Business.Interfaces;

public interface ICuadradoService
{
    Task<Cuadrado> GetArea(int lado);
}
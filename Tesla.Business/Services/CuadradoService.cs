using Tesla.Business.Interfaces;
using Tesla.Models;

namespace Tesla.Business.Services;

public class CuadradoService: ICuadradoService
{
    public async Task<Cuadrado> GetArea(int lado)
    {
        var cuadrado = new Cuadrado
        {
            Lado = lado,
            Area = lado * lado
        };

        return await Task.FromResult(cuadrado);
    }
}
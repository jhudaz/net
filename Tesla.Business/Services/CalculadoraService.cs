using Tesla.Business.Interfaces;
using Tesla.Models;

namespace Tesla.Business.Services;

public class CalculadoraService : ICalculadoraService
{
    public async Task<Calculadora> Sumar( int num1, int num2)
    {
        var calculadora = new Calculadora
        {
            Num1 = num1,
            Num2 = num2,
            Resultado = num1 + num2
        };

        return await Task.FromResult(calculadora);
    }
}
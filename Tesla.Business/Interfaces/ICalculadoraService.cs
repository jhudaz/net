using Tesla.Models;

namespace Tesla.Business.Interfaces;

public interface ICalculadoraService
{
    Task<Calculadora> Sumar(int num1, int num2);
}
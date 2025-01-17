namespace Tesla.Services
{
    using Tesla.Models;

    public interface ICalculadoraService
    {
        Task<Calculadora> Sumar(int num1, int num2);
    }
}
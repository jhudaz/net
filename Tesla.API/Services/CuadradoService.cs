namespace Tesla.Services
{
    using Tesla.Models;

    public class CuadradoService: ICuadradoService
    {
        public async Task<Cuadrado> Area(int lado)
        {
            var cuadrado = new Cuadrado
            {
                Lado = lado,
                Area = lado * lado
            };

            return await Task.FromResult(cuadrado);
        }
    }
}
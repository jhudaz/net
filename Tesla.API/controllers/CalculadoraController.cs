namespace Tesla.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Tesla.Models;
    using Tesla.Services;

    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : ControllerBase
    {
        //declarar servicio
        private readonly ICalculadoraService _calculadoraService;
        
        //inyectar servicio
        public CalculadoraController(ICalculadoraService calculadoraService)
        {
            _calculadoraService = calculadoraService;
        }

        //request
        [HttpPost("sumar")]
        public async Task<IActionResult> Sumar([FromBody] Calculadora request)
        {
            var resultado = await _calculadoraService.Sumar(request.Num1, request.Num2);
            return Ok(resultado);
        }
    }
}
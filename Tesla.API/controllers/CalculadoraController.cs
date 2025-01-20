using Microsoft.AspNetCore.Mvc;
using Tesla.Business.Interfaces;
using Tesla.Models;

namespace Tesla.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculadoraController : ControllerBase
{
    private readonly ICalculadoraService _calculadoraService;

    public CalculadoraController(ICalculadoraService calculadoraService)
    {
        _calculadoraService = calculadoraService;
    }

    [HttpPost("sumar")]
    public async Task<IActionResult> Sumar([FromBody]Calculadora request)
    {
        var suma = await _calculadoraService.Sumar(request.Num1, request.Num2);
        return Ok(suma);    
    }



}
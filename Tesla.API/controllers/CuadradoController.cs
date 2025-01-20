using Microsoft.AspNetCore.Mvc;
using Tesla.Business.Interfaces;
using Tesla.Models;

namespace Tesla.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CuadradoController : ControllerBase 
{
    private readonly ICuadradoService _cuadradoService;

    public CuadradoController(ICuadradoService cuadradoService)
    {
        _cuadradoService = cuadradoService;
    }


    [HttpPost("GetArea")]
    public async Task<IActionResult> GetArea([FromBody]Cuadrado request)
    {
        var area = await _cuadradoService.GetArea(request.Lado);
        return Ok(area);
    }
}

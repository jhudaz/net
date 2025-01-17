namespace Tesla.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Tesla.Models;
    using Tesla.Services;

    [ApiController]
    [Route("api/[controller]")]
    public class CuadradoController: ControllerBase
    {
        //declarar servicio
        private readonly ICuadradoService _cuadradoService;

        //inyeccion del servicio
        public CuadradoController(ICuadradoService cuadradoService)
        {
            _cuadradoService = cuadradoService;
        }

        //request
        [HttpPost]
        public async Task<IActionResult> Area([FromBody]Cuadrado request)
        {
            var resultado = await _cuadradoService.Area(request.Lado);
            return Ok(resultado);
        }

    }
}


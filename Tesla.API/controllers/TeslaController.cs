using Microsoft.AspNetCore.Mvc;

namespace Tesla.Controllers;

[ApiController]
[Route("GetAlbum")]
public class TeslaController : ControllerBase
{
    // public async Task<IActionResult> GetAlbum(){
    //     var album = new Album(){
    //         Nombre = "",
    //         Genero = "",
    //         Anio = 2000
    //     }
    // }

    [HttpPost]
    [Route("RecibirValor")]

    public async Task<IActionResult> RecibirValor(string nombre)
    {
        return Ok("mi nombre es " + nombre);
    }

}


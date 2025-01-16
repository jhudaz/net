using Microsoft.AspNetCore.Mvc;

namespace Tesla.Controllers;

[ApiController]
[Route("api/[controller]")]
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
    public async Task<IActionResult> RecibirValor(string nombre)
    {
        return Ok("mi nombre es " + nombre);
    }

}


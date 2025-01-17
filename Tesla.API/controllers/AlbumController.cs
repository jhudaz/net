namespace Tesla.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Tesla.Services;

    [ApiController]
    [Route("api/[controller]")]
    public class AlbumController : ControllerBase
    {
        //definir servicio
        private readonly IAlbumService _albumService;

        //inyectar servicio
        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        //request 
        [HttpGet("albumes")]
        public async Task<IActionResult> GetAlbums()
        {
            var albums = await _albumService.GetAllAlbums();
            return Ok(albums);
        }
    }
}
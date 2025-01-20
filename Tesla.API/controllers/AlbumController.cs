using Microsoft.AspNetCore.Mvc;
using Tesla.Business.Interfaces;

namespace Tesla.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlbumController : ControllerBase
{
    private readonly IAlbumService _albumService;

    public AlbumController(IAlbumService albumService)
    {
        _albumService = albumService;
    }

    [HttpGet("GetAllAlbums")]
    public async Task<IActionResult> GetAllAlbums()
    {
        var albums = await _albumService.GetAllAlbums();
        return Ok(albums);
    }

}


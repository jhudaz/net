using Tesla.Models;

namespace Tesla.Business.Interfaces;

public interface IAlbumService
{
    Task<IEnumerable<Album>> GetAllAlbums();
}
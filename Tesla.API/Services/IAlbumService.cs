namespace Tesla.Services
{
    using Tesla.Models;
    
    public interface IAlbumService
    {
        Task<IEnumerable<Album>> GetAllAlbums();
    }
}


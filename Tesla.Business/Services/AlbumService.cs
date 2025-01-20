using Tesla.Business.Interfaces;
using Tesla.Models;

namespace Tesla.Business.Services;

public class AlbumService: IAlbumService
{
    private readonly List<Album> _albums = new()
    {
        new Album { Nombre = "Album 1", Genero = "Rock", Anio = 2020 },
        new Album { Nombre = "Album 2", Genero = "Pop", Anio = 2021 },
        new Album { Nombre = "Album 3", Genero = "Jazz", Anio = 2022 }
    };

    public async Task<IEnumerable<Album>> GetAllAlbums()
    {
        return await Task.FromResult(_albums);
    }
}
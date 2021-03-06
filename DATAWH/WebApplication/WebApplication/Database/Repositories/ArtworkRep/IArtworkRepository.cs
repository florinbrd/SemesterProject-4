using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Datamodel;

namespace WebApplication.Database.Repositories.ArtworkRep
{
    public interface IArtworkRepository : IRepositoryBase<Artwork>
    {
        Task<IEnumerable<Artwork>> GetAllArtWorksAsync();

        Task<Artwork> GetArtworkById(int artId);

        Task<IEnumerable<Artwork>> GetArtworksByRoom(string Location);

        void CreateArtWork(Artwork artwork);

        void UpdateArtwork(Artwork artwork);

        void DeleteArtwork(Artwork artwork);
        
        bool ArtworkExists(int artId);

        Task saveChanges();


    }
}
using MegicVilla_VillaAPI1.Models;

namespace MegicVilla_VillaAPI1.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}

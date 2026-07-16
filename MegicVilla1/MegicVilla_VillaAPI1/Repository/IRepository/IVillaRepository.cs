using MegicVilla_VillaAPI1.Models;
using System.Linq.Expressions;

namespace MegicVilla_VillaAPI1.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
       Task<Villa> UpdateAsync(Villa entity);
        
    }
}

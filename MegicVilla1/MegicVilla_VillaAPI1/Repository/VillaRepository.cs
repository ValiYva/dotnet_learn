using MegicVilla_VillaAPI1.Data;
using MegicVilla_VillaAPI1.Models;
using MegicVilla_VillaAPI1.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MegicVilla_VillaAPI1.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

      

        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}

using MegicVilla_VillaAPI1.Data;
using MegicVilla_VillaAPI1.Models;

namespace MegicVilla_VillaAPI1.Repository.IRepository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaNumberRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.ChangeTracker.Clear();
            _db.VillaNumbers.Update(entity);
            await _db.SaveChangesAsync();
            return entity;   
        }

        public async Task CreateAsync(VillaNumber entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.UpdatedDate = DateTime.Now;
            await base.CreateAsync(entity);
        }
    }

}

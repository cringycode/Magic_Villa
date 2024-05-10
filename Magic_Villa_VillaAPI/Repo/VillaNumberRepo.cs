using Magic_Villa_VillaAPI.Data;
using Magic_Villa_VillaAPI.Models;
using Magic_Villa_VillaAPI.Repo.IRepo;

namespace Magic_Villa_VillaAPI.Repo;

public class VillaNumberRepo : Repo<VillaNumber>, IVillaNumberRepo
{
    private readonly ApplicationDbContext _db;
    private IVillaNumberRepo _villaNumberRepoImplementation;

    public VillaNumberRepo(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }


    public async Task<VillaNumber> Update(VillaNumber entity)
    {
        entity.UpdatedDate = DateTime.Now;
        _db.VillaNumbers.Update(entity);
        await _db.SaveChangesAsync();
        return entity;
    }
}
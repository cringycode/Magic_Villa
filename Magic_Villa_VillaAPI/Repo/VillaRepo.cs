using System.Linq.Expressions;
using Magic_Villa_VillaAPI.Data;
using Magic_Villa_VillaAPI.Models;
using Magic_Villa_VillaAPI.Repo.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Magic_Villa_VillaAPI.Repo;

public class VillaRepo : Repo<Villa>, IVillaRepo
{
    #region DI

    private readonly ApplicationDbContext _db;

    public VillaRepo(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    #endregion

    public async Task<Villa> Update(Villa entity)
    {
        entity.UpdatedDate = DateTime.Now;
        _db.Villas.Update(entity);
        await _db.SaveChangesAsync();
        return entity;
    }
}
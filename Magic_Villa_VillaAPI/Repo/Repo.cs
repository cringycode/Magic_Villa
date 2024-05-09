using System.Linq.Expressions;
using Magic_Villa_VillaAPI.Data;
using Magic_Villa_VillaAPI.Models;
using Magic_Villa_VillaAPI.Repo.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Magic_Villa_VillaAPI.Repo;

public class Repo<T> : IRepo<T> where T : class
{
    #region DI

    private readonly ApplicationDbContext _db;
    internal DbSet<T> dbSet;

    public Repo(ApplicationDbContext db)
    {
        _db = db;
        this.dbSet = _db.Set<T>();
    }

    #endregion

    public async Task<List<T>> GetAll(Expression<Func<T, bool>>? filter = null)
    {
        IQueryable<T> query = dbSet;

        if (filter is not null)
        {
            query = query.Where(filter);
        }

        return await query.ToListAsync();
    }

    public async Task<T> Get(Expression<Func<T, bool>> filter = null, bool tracked = true)
    {
        IQueryable<T> query = dbSet;
        if (!tracked)
        {
            query = query.AsNoTracking();
        }

        if (filter is not null)
        {
            query = query.Where(filter);
        }

        return await query.FirstOrDefaultAsync();
    }

    public async Task Create(T entity)
    {
        await dbSet.AddAsync(entity);
        await Save();
    }

    public async Task Remove(T entity)
    {
        dbSet.Remove(entity);
        await Save();
    }

    public async Task Save()
    {
        await _db.SaveChangesAsync();
    }
}
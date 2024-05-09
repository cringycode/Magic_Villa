﻿using System.Linq.Expressions;
using Magic_Villa_VillaAPI.Data;
using Magic_Villa_VillaAPI.Models;
using Magic_Villa_VillaAPI.Repo.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Magic_Villa_VillaAPI.Repo;

public class VillaRepo : IVillaRepo
{
    #region DI

    private readonly ApplicationDbContext _db;

    public VillaRepo(ApplicationDbContext db)
    {
        _db = db;
    }

    #endregion

    public async Task<List<Villa>> GetAll(Expression<Func<Villa, bool>>? filter = null)
    {
        IQueryable<Villa> query = _db.Villas;

        if (filter is not null)
        {
            query = query.Where(filter);
        }

        return await query.ToListAsync();
    }

    public async Task<Villa> Get(Expression<Func<Villa, bool>>? filter = null, bool tracked = true)
    {
        IQueryable<Villa> query = _db.Villas;
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

    public async Task Create(Villa entity)
    {
        await _db.Villas.AddAsync(entity);
        await Save();
    }

    public async Task Update(Villa entity)
    {
        _db.Villas.Update(entity);
        await Save();
    }

    public async Task Remove(Villa entity)
    {
        _db.Villas.Remove(entity);
        await Save();
    }

    public async Task Save()
    {
        await _db.SaveChangesAsync();
    }
}
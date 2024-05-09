using System.Linq.Expressions;
using Magic_Villa_VillaAPI.Models;

namespace Magic_Villa_VillaAPI.Repo.IRepo;

public interface IVillaRepo
{
    Task<List<Villa>> GetAll(Expression<Func<Villa, bool>>? filter = null);
    Task<Villa> Get(Expression<Func<Villa,bool>>? filter = null, bool tracked = true);
    Task Create(Villa entity);
    Task Update(Villa entity);
    Task Remove(Villa entity);
    Task Save();
}
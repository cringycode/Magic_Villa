using System.Linq.Expressions;
using Magic_Villa_VillaAPI.Models;

namespace Magic_Villa_VillaAPI.Repo.IRepo;

public interface IVillaRepo : IRepo<Villa>
{
    Task<Villa> Update(Villa entity);
}
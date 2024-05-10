using Magic_Villa_VillaAPI.Models;

namespace Magic_Villa_VillaAPI.Repo.IRepo;

public interface IVillaNumberRepo : IRepo<VillaNumber>
{
    Task<VillaNumber> Update(VillaNumber entity);
}